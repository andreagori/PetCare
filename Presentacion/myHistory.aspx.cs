using System;
using System.Collections.Generic;
using Entidades;
using Negocios;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System.IO;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.DocumentObjectModel.Shapes;

namespace Presentacion
{
    public partial class myHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadHistorical();
        }

        private void LoadHistorical()
        {
            if (Session["IdPet"] != null)
            {
                int idPet = (int)Session["IdPet"];
                List<E_Date> list = new N_Pets().HistoricalPet(idPet);
                if (list != null && list.Count > 0)
                {
                    rpHistory.DataSource = list;
                    rpHistory.DataBind();
                }
                //else
                //{
                //    Response.Write("No hay datos para mostrar.");
                //}

            }
            //else
            //{
            //    Response.Write("No se encontró el IdPet en la sesión.");
            //}
        }

        protected void ExportToPdf(object sender, EventArgs e)
        {
            if (Session["IdPet"] != null)
            {
                int idPet = (int)Session["IdPet"];

                // Obtener los detalles de la mascota para el nombre
                E_Pet petDetails = new N_Owner().GetPet(idPet);

                // Validar si se obtuvo la mascota
                if (petDetails != null)
                {
                    string petName = petDetails.NamePet;

                    // Obtener historial de actividades
                    List<E_Date> history = new N_Pets().HistoricalPet(idPet);

                    if (history != null && history.Count > 0)
                    {
                        // Crear documento con MigraDoc
                        Document document = new Document();
                        Section section = document.AddSection();

                        var image = section.AddImage(Server.MapPath("~/assets/icons/Logo.png"));
                        image.Width = MigraDoc.DocumentObjectModel.Unit.FromCentimeter(5); // Ajusta el tamaño de la imagen
                        image.Height = MigraDoc.DocumentObjectModel.Unit.FromCentimeter(5);
                        image.LockAspectRatio = true;
                        image.Left = ShapePosition.Center;

                        // Título del documento
                        Paragraph docTitulo = section.AddParagraph($"Historial de Actividades - Mascota: {petName}");
                        docTitulo.Format.Font.Size = 24;
                        docTitulo.Format.Alignment = ParagraphAlignment.Center;
                        docTitulo.Format.Font.Bold = true;

                        section.AddParagraph("\n");

                        // Crear tabla
                        MigraDoc.DocumentObjectModel.Tables.Table table = section.AddTable();
                        table.Borders.Width = 0.75;

                        // Definir columnas
                        Column column1 = table.AddColumn(MigraDoc.DocumentObjectModel.Unit.FromCentimeter(5));
                        Column column2 = table.AddColumn(MigraDoc.DocumentObjectModel.Unit.FromCentimeter(4));
                        Column column3 = table.AddColumn(MigraDoc.DocumentObjectModel.Unit.FromCentimeter(8));

                        // Encabezado de la tabla
                        Row headerRow = table.AddRow();
                        headerRow.Shading.Color = MigraDoc.DocumentObjectModel.Colors.LightGray;
                        headerRow.Cells[0].AddParagraph("Fecha").Format.Font.Bold = true;
                        headerRow.Cells[1].AddParagraph("Tipo de Actividad").Format.Font.Bold = true;
                        headerRow.Cells[2].AddParagraph("Descripción").Format.Font.Bold = true;

                        // Llenar filas de la tabla con datos
                        foreach (var item in history)
                        {
                            Row row = table.AddRow();
                            row.Cells[0].AddParagraph(item.StartTime.ToShortDateString())
                                        .Format.Font.Bold = true; // Fecha en negritas
                            row.Cells[1].AddParagraph(item.EventType)
                                        .Format.Font.Bold = true; // Tipo en negritas
                            row.Cells[2].AddParagraph(item.Title); // Descripción en texto normal
                        }

                        section.AddParagraph("\n");

                        // Renderizar el documento
                        PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true);
                        pdfRenderer.Document = document;
                        pdfRenderer.RenderDocument();

                        // Guardar y enviar el PDF al cliente
                        using (MemoryStream stream = new MemoryStream())
                        {
                            pdfRenderer.Save(stream, false);
                            Response.Clear();
                            Response.ContentType = "application/pdf";
                            Response.AddHeader("content-disposition", "attachment;filename=HistorialMascota.pdf");
                            Response.BinaryWrite(stream.ToArray());
                            Response.End();
                        }
                    }
                }
            }
        }
    }
}