using System;
using System.Collections.Generic;
using Entidades;
using Negocios;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System.IO;

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
                        section.AddParagraph($"Historial de Actividades - Mascota: {petName}");

                        foreach (var item in history)
                        {
                            section.AddParagraph($"Fecha: {item.StartTime}, {item.DateType}: {item.Title}");
                        }

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