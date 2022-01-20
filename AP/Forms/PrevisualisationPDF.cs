using AP.Model;
using AP.Services;
using AP.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AP.Forms
{
    public partial class PrevisualisationPDF : Form
    {
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private List<ReservationHebergement> _reservationsHebergement;
        private Utilisateur _utilisateur;
        private decimal _gains = 0;

        public PrevisualisationPDF(DateTime dateTime1, DateTime dateTime2, Utilisateur utilisateur)
        {
            InitializeComponent();
            this._dateDebut = dateTime1;
            this._dateFin = dateTime2;
            this._utilisateur = utilisateur;
            this._reservationsHebergement = _utilisateur.GetReservationsBetween(dateTime1, dateTime2);

            for (int i = 0; i < _reservationsHebergement.Count; i++)
            {
                _gains += _reservationsHebergement[i].Prix;
                if (i % 2 == 0)
                {
                    flowLayoutPanelDonnees.Controls.Add(new LignePrevisualisationPDF(_reservationsHebergement[i], false));
                }
                else
                {
                    flowLayoutPanelDonnees.Controls.Add(new LignePrevisualisationPDF(_reservationsHebergement[i], true));
                }
            }

            labelNom.Text = _utilisateur.Nom;
            labelPrenom.Text = _utilisateur.Prenom;
            labelUserId.Text = "ID : " + _utilisateur.IdUtilisateur.ToString();
            labelPeriode.Text = "Du " + dateTime1.ToShortDateString() + " au " + dateTime2.ToShortDateString();
            labelGains.Text = "Gains : " +  _gains.ToString() + " €";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string folder = folderBrowserDialog1.SelectedPath;

                PDF PDF = new PDF(_utilisateur, _reservationsHebergement, folder, _dateDebut, _dateFin);
                PDF.GeneratePDF();

            }
        }
    }
}
