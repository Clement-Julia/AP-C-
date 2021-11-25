using AP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Hebergement Hebergement = new Hebergement(_reservationHebergement.IdHebergement);

            labelIdReservation.Text = _reservationHebergement.IdReservationHebergement.ToString();
            labelPeriode.Text = "Du " + _reservationHebergement.DateDebut.ToString("dd-MM-yyyy") + " au " + _reservationHebergement.DateFin.ToString("dd-MM-yyyy");
            labelVille.Text = Ville.Libelle;
            labelHebergement.Text = Hebergement.Libelle;
            labelGains.Text = _reservationHebergement.Prix.ToString() + " €";

            if (colorTrueOrFalse)
            {
                this.BackColor = Color.FromArgb(228, 228, 228);
            }
        }

    }
}
