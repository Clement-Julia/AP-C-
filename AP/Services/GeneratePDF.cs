using AP.Model;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP.Services
{
    public class GeneratePDF
    {
        private string _nom;
        private string _prenom;
        private string _id;
        private string _periode;
        private string _folder;
        private decimal _gains;
        private DateTime _du;
        private DateTime _au;

        private List<ReservationHebergement> _reservationHebergements;

        public GeneratePDF(string nom, string prenom, string id, string periode, List<ReservationHebergement> reservationHebergements, string folder, DateTime du, DateTime au)
        {
            this._nom = nom;
            this._prenom = prenom;
            this._id = id;
            this._periode = periode;
            this._reservationHebergements = reservationHebergements;
            this._folder = folder;
            this._du = du;
            this._au = au;
        }

        public void Pdf()
        {
            string pdfName = $"{_nom} {_prenom} - {_du.ToString("dd-MM-yyyy")} au {_au.ToString("dd-MM-yyyy")}.pdf";

            string exportFile = System.IO.Path.Combine(_folder, pdfName);

            using (var writer = new PdfWriter(exportFile))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf);

                    doc.SetMargins(75, 35, 70, 35);

                    Color lightSeaGreen = new DeviceRgb(32, 178, 170);
                    Color lightGray = new DeviceRgb(230, 230, 230);

                    Style styleText = new Style()
                        .SetFontSize(12);
                    Style styleCellHeader = new Style()
                        .SetFontSize(12)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetBackgroundColor(lightSeaGreen)
                        .SetHeight(22)
                        .SetFontColor(ColorConstants.BLACK);
                    Style styleCellWhite = new Style()
                        .SetFontSize(12)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetBackgroundColor(ColorConstants.WHITE);
                    Style styleCellGray = new Style()
                        .SetFontSize(12)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetBackgroundColor(lightGray);

                    doc.Add(new Paragraph(_nom).SetFontSize(14).SetTextAlignment(TextAlignment.LEFT).AddStyle(styleText));
                    doc.Add(new Paragraph(_prenom).SetFontSize(14).SetTextAlignment(TextAlignment.LEFT).AddStyle(styleText));
                    doc.Add(new Paragraph(_id).SetFontSize(14).SetTextAlignment(TextAlignment.LEFT).AddStyle(styleText));
                    doc.Add(new Paragraph(_periode).SetFontSize(14).SetTextAlignment(TextAlignment.RIGHT).AddStyle(styleText));

                    doc.Add(new Paragraph(" "));

                    Table _table = new Table(8).UseAllAvailableWidth();
                    Cell _cell = new Cell(1,1).Add(new Paragraph("N°"));
                    _table.AddCell(_cell.AddStyle(styleCellHeader));
                    _cell = new Cell(1,2).Add(new Paragraph("Période"));
                    _table.AddCell(_cell.AddStyle(styleCellHeader));
                    _cell = new Cell(1,2).Add(new Paragraph("Ville"));
                    _table.AddCell(_cell.AddStyle(styleCellHeader));
                    _cell = new Cell(1,2).Add(new Paragraph("Hébergement"));
                    _table.AddCell(_cell.AddStyle(styleCellHeader));
                    _cell = new Cell(1,1).Add(new Paragraph("Gains"));
                    _table.AddCell(_cell.AddStyle(styleCellHeader));

                    for (int i = 0; i < _reservationHebergements.Count; i++)
                    {
                        this._gains += _reservationHebergements[i].Prix;

                        Ville Ville = _reservationHebergements[i].GetVilleInfos();
                        Hebergement Hebergement = new Hebergement(_reservationHebergements[i].IdHebergement);

                        Style style = new Style();
                        if(i%2 == 0) { style = styleCellWhite; } else { style = styleCellGray; }

                        _cell = new Cell(1,1).Add(new Paragraph(_reservationHebergements[i].IdReservationHebergement.ToString()));
                        _cell.SetBorder(Border.NO_BORDER);
                        _table.AddCell(_cell.AddStyle(style));
                        _cell = new Cell(1,2).Add(new Paragraph($"Du {_reservationHebergements[i].DateDebut.ToString("dd-MM-yyyy")} au {_reservationHebergements[i].DateFin.ToString("dd-MM-yyyy")}"));
                        _cell.SetBorder(Border.NO_BORDER);
                        _table.AddCell(_cell.AddStyle(style));
                        _cell = new Cell(1,2).Add(new Paragraph(Ville.Libelle));
                        _cell.SetBorder(Border.NO_BORDER);
                        _table.AddCell(_cell.AddStyle(style));
                        _cell = new Cell(1,2).Add(new Paragraph(Hebergement.Libelle));
                        _cell.SetBorder(Border.NO_BORDER);
                        _table.AddCell(_cell.AddStyle(style));
                        _cell = new Cell(1,1).Add(new Paragraph($"{_reservationHebergements[i].Prix.ToString()} €"));
                        _cell.SetBorder(Border.NO_BORDER);
                        _table.AddCell(_cell.AddStyle(style));
                    }

                    doc.Add(_table);

                    doc.Add(new Paragraph(" "));
                    doc.Add(new Paragraph($"Gains : {_gains} €").SetFontSize(14).SetTextAlignment(TextAlignment.RIGHT).AddStyle(styleText));

                    doc.Close();
                }
            }

            MessageBox.Show($"Votre PDF a été généré avec succès \nChemin d'accès : {_folder}", "Génération du PDF");

        }
    }
}
