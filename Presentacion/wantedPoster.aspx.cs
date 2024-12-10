using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocios;
using Datos;
using System.Xml.Linq;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System.IO;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;

namespace Presentacion
{
    public partial class wantedPoster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadName();
        }

        protected void LoadName()
        {
            if (Request.QueryString["IdPet"] != null && int.TryParse(Request.QueryString["IdPet"], out int idPet))
            {
                // Obtén los detalles de la mascota desde la capa de negocios
                E_Pet petDetails = new N_Owner().GetPet(idPet);

                // Verifica si los detalles de la mascota están disponibles
                if (petDetails != null)
                {
                    // Carga el nombre de la mascota
                    petName.Text = petDetails.NamePet;

                    // Determina el sexo de la mascota
                    string sex = petDetails.Sex ? "Macho" : "Hembra";

                    // Carga los datos de la mascota
                    petData.Text = $"{petDetails.NamePet}, {petDetails.Age} años, {sex}, Especie: {petDetails.Specie}, Raza: {petDetails.Breed}, Peso: {petDetails.Weight} kg";

                    // Carga los datos del dueño desde la sesión
                    E_Owner owner = (E_Owner)Session["Owner"];
                    if (owner != null)
                    {
                        ownerData.Text = $"{owner.Name}, Teléfono: {owner.CellPhone}, Dirección: {owner.Address}";
                    }
                }
                else
                {
                    petName.Text = "Mascota no encontrada";
                    petData.Text = string.Empty;
                    ownerData.Text = string.Empty;
                }
            }
            else
            {
                petName.Text = "ID de mascota no válido";
                petData.Text = string.Empty;
                ownerData.Text = string.Empty;
            }
        }

        protected void ExportToPdf(object sender, EventArgs e)
        {
            // Obtener el ID de la mascota desde el query string
            if (!int.TryParse(Request.QueryString["IdPet"], out int idPet))
            {
                Response.Write("<script>alert('ID de mascota inválido.');</script>");
                return;
            }

            // Obtener el dueño desde la sesión
            E_Owner owner = (E_Owner)Session["Owner"];
            if (owner == null)
            {
                Response.Write("<script>alert('No se encontró el dueño de la mascota.');</script>");
                return;
            }

            // Obtener la lista de mascotas del dueño
            List<E_Pet> pets = new N_Owner().GetOwnerPets(owner.IdOwner);
            E_Pet currentPet = pets.FirstOrDefault(p => p.IdPet == idPet);

            if (currentPet == null)
            {
                Response.Write("<script>alert('No se encontró la información de la mascota.');</script>");
                return;
            }

            // Crear el documento PDF
            Document document = new Document();
            Section section = document.AddSection();

            // Agregar encabezado con logo y nombre del proyecto
            MigraDoc.DocumentObjectModel.Tables.Table headerTable = section.AddTable();
            headerTable.Borders.Visible = false;

            // Configurar columnas
            Column logoColumn = headerTable.AddColumn(MigraDoc.DocumentObjectModel.Unit.FromCentimeter(3));
            Column textColumn = headerTable.AddColumn(MigraDoc.DocumentObjectModel.Unit.FromCentimeter(12));

            // Crear una fila
            Row headerRow = headerTable.AddRow();

            // Agregar logo
            if (!string.IsNullOrEmpty(currentPet.PhotoPet)) // Aquí usarías el logo real de tu programa
            {
                try
                {
                    var logoImage = headerRow.Cells[0].AddImage(Server.MapPath("~/assets/icons/Logo.png"));
                    logoImage.Width = MigraDoc.DocumentObjectModel.Unit.FromCentimeter(2);
                    logoImage.Height = MigraDoc.DocumentObjectModel.Unit.FromCentimeter(2);
                    logoImage.LockAspectRatio = true;
                }
                catch
                {
                    headerRow.Cells[0].AddParagraph("Logo no disponible.");
                }
            }

            // Agregar título del proyecto
            Paragraph titleParagraph = headerRow.Cells[1].AddParagraph("PetCare - Poster de Búsqueda");
            titleParagraph.Format.Font.Size = 20;
            titleParagraph.Format.Font.Bold = true;
            titleParagraph.Format.Alignment = ParagraphAlignment.Left;
            section.AddParagraph("\n");

            // Título principal "SE BUSCA"
            Paragraph mainTitle = section.AddParagraph("¡SE BUSCA!");
            mainTitle.Format.Font.Size = 30;
            mainTitle.Format.Font.Bold = true;
            mainTitle.Format.Font.Color = Colors.Red;
            mainTitle.Format.Alignment = ParagraphAlignment.Center;
            section.AddParagraph("\n");

            // Agregar imagen de la mascota
            if (!string.IsNullOrEmpty(currentPet.PhotoPet))
            {
                try
                {
                    var image = section.AddImage(Server.MapPath(currentPet.PhotoPet));
                    image.Width = MigraDoc.DocumentObjectModel.Unit.FromCentimeter(7); // Ajusta el tamaño de la imagen
                    image.Height = MigraDoc.DocumentObjectModel.Unit.FromCentimeter(7);
                    image.LockAspectRatio = true;
                    image.Left = ShapePosition.Center;
                }
                catch
                {
                    section.AddParagraph("Imagen no disponible.")
                           .Format.Alignment = ParagraphAlignment.Center;
                }
            }

            section.AddParagraph("\n");

            // Obtener los datos de la mascota utilizando el método GetPetDetails
            E_Pet petDetails = new N_Owner().GetPet(idPet);
            if (petDetails == null)
            {
                Response.Write("<script>alert('No se encontró la información de la mascota.');</script>");
                return;
            }

            // Agregar datos de la mascota
            Paragraph nombre = section.AddParagraph($"{petDetails.NamePet}");
            nombre.Format.Alignment = ParagraphAlignment.Center;
            nombre.Format.Font.Size = 20;
            nombre.Format.Font.Bold = true;


            Paragraph datosMascota = section.AddParagraph("Datos de la Mascota");
            datosMascota.Format.Font.Size = 18;
            datosMascota.Format.Alignment = ParagraphAlignment.Center;
            datosMascota.Format.Font.Bold = true;

            Paragraph edad = section.AddParagraph();
            edad.AddFormattedText("Edad: ", TextFormat.Bold);
            edad.AddText($"{petDetails.Age} años");
            edad.Format.Font.Size = 14;

            Paragraph sexo = section.AddParagraph();
            sexo.AddFormattedText("Sexo: ", TextFormat.Bold);
            sexo.AddText(petDetails.Sex ? "Macho" : "Hembra");
            sexo.Format.Font.Size = 14;

            Paragraph raza = section.AddParagraph();
            raza.AddFormattedText("Raza: ", TextFormat.Bold);
            raza.AddText(petDetails.Breed);
            raza.Format.Font.Size = 14;

            Paragraph especie = section.AddParagraph();
            especie.AddFormattedText("Especie: ", TextFormat.Bold);
            especie.AddText(petDetails.Specie);
            especie.Format.Font.Size = 14;

            Paragraph peso = section.AddParagraph();
            peso.AddFormattedText("Peso: ", TextFormat.Bold);
            peso.AddText($"{petDetails.Weight} kg");
            peso.Format.Font.Size = 14;

            section.AddParagraph("\n");
            section.AddParagraph("\n");
            section.AddParagraph("\n");
            section.AddParagraph("\n");
            section.AddParagraph("\n");

            // Nota de informacion owner
            Paragraph ownerInfo = section.AddParagraph("INFORMACION DE CONTACTO");
            ownerInfo.Format.Font.Size = 18;
            ownerInfo.Format.Font.Bold = true;
            ownerInfo.Format.Alignment = ParagraphAlignment.Center;
            ownerInfo.Format.Font.Color = Colors.Red;

            // Detalles del dueño
            section.AddParagraph("\n");

            Paragraph ownerName = section.AddParagraph();
            ownerName.AddFormattedText("Nombre: ", TextFormat.Bold);
            ownerName.AddText(owner.Name);
            ownerName.Format.Font.Size= 14;

            Paragraph ownerEmail = section.AddParagraph();
            ownerEmail.AddFormattedText("Correo Electrónico: ", TextFormat.Bold);
            ownerEmail.AddText(owner.Email);
            ownerEmail.Format.Font.Size = 14;

            Paragraph ownerPhone = section.AddParagraph();
            ownerPhone.AddFormattedText("Teléfono: ", TextFormat.Bold);
            ownerPhone.AddText(owner.CellPhone);
            ownerPhone.Format.Font.Size = 14;

            Paragraph ownerAddress = section.AddParagraph();
            ownerAddress.AddFormattedText("Dirección: ", TextFormat.Bold);
            ownerAddress.AddText(owner.Address);
            ownerAddress.Format.Font.Size = 14;

            // Renderizar el documento a PDF
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true)
            {
                Document = document
            };
            renderer.RenderDocument();

            // Enviar el PDF al cliente
            using (MemoryStream stream = new MemoryStream())
            {
                renderer.Save(stream, false);
                Response.Clear();
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-disposition", "attachment;filename=WantedPoster.pdf");
                Response.BinaryWrite(stream.ToArray());
                Response.End();
            }
        }
    }
}