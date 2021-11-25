using AP.Model;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.Services
{
    public class GeneratePDF
    {
        private string _nom;
        private string _prenom;
        private string _id;
        private string _periode;
        private string _folder;

        private List<ReservationHebergement> _reservationHebergements;

        public GeneratePDF(string nom, string prenom, string id, string periode, List<ReservationHebergement> reservationHebergements, string folder)
        {
            this._nom = nom;
            this._prenom = prenom;
            this._id = id;
            this._periode = periode;
            this._reservationHebergements = reservationHebergements;
            this._folder = folder;
        }

        public void Pdf()
        {
            string pdfName = _nom + " - " + _prenom + "fiscalite.pdf";

            string exportFile = System.IO.Path.Combine(_folder, pdfName);

            using (var writer = new PdfWriter(exportFile))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf);

                    doc.SetMargins(75, 35, 70, 35);

                    doc.Add(new Paragraph(_nom).SetFontSize(14).SetTextAlignment(TextAlignment.LEFT));
                    doc.Add(new Paragraph(_prenom).SetFontSize(14).SetTextAlignment(TextAlignment.LEFT));
                    doc.Add(new Paragraph(_id).SetFontSize(14).SetTextAlignment(TextAlignment.LEFT));
                    doc.Add(new Paragraph(_periode).SetFontSize(14).SetTextAlignment(TextAlignment.RIGHT));

                    doc.Close();
                }
            }


            //byte[] bytesSteam = ms.ToArray();
            //ms = new MemoryStream();
            //ms.Write(bytesSteam, 0, bytesSteam.Length);
            //ms.Position = 0;

            //return new FileStreamResult(ms, "application/pdf");
        }
    }
}
