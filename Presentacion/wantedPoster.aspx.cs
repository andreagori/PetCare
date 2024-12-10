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
                E_Pet petDetails = new N_Pets().GetPetDetails(idPet);

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

            // Agregar título
            section.AddParagraph("¡¡SE BUSCA!!")
                   .Format.Font.Size = 24;
            section.AddParagraph("\n");

            // Agregar imagen de la mascota
            if (!string.IsNullOrEmpty(currentPet.PhotoPet))
            {
                try
                {
                    var image = section.AddImage(Server.MapPath(currentPet.PhotoPet));
                    image.Width = MigraDoc.DocumentObjectModel.Unit.FromCentimeter(5); // Ajusta el tamaño de la imagen
                    image.Height = MigraDoc.DocumentObjectModel.Unit.FromCentimeter(5);
                    image.LockAspectRatio = true;
                }
                catch
                {
                    section.AddParagraph("Imagen no disponible.");
                }
            }

            // Obtener los datos de la mascota utilizando el método GetPetDetails
            E_Pet petDetails = new N_Pets().GetPetDetails(idPet);
            if (petDetails == null)
            {
                Response.Write("<script>alert('No se encontró la información de la mascota.');</script>");
                return;
            }

            // Agregar datos de la mascota
            section.AddParagraph("Datos de la Mascota:");
            section.AddParagraph($"Nombre: {petDetails.NamePet}");
            section.AddParagraph($"Edad: {petDetails.Age} años");
            section.AddParagraph($"Sexo: {(petDetails.Sex ? "Macho" : "Hembra")}");
            section.AddParagraph($"Raza: {petDetails.Breed}");
            section.AddParagraph($"Especie: {petDetails.Specie}");
            section.AddParagraph($"Peso: {petDetails.Weight} kg");
            section.AddParagraph("\n");

            // Nota de recompensa
            section.AddParagraph("SE DARÁ RECOMPENSA")
                   .Format.Font.Size = 18;

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