using AP.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AP.UserControls
{
    public partial class LignePrevisualisationPDF : UserControl
    {
        private ReservationHebergement _reservationHebergement;
        public LignePrevisualisationPDF(ReservationHebergement reservationHebergement, Boolean colorTrueOrFalse)
        {
            InitializeComponent();
            this._reservationHebergement = reservationHebergement;
            Ville Ville = _reservationHebergement.GetVilleInfos();

            labelIdReservation.Text = _reservationHebergement.IdReservationHebergement.ToString();
            labelPeriode.Text = "Du " + _reservationHebergement.DateDebut.ToString("dd-MM-yyyy") + " au " + _reservationHebergement.DateFin.ToString("dd-MM-yyyy");
            labelVille.Text = Ville.Libelle;
            labelHebergement.Text = _reservationHebergement.Hebergement.Libelle;
            labelGains.Text = _reservationHebergement.Prix.ToString() + " €";

            if (colorTrueOrFalse)
            {
                this.BackColor = Color.FromArgb(228, 228, 228);
            }
        }

    }
}
