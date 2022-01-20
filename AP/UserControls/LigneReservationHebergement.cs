using AP.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AP.UserControls
{
    public partial class LigneReservationHebergement : UserControl
    {
        private ReservationHebergement _reservationHebergement;
        private Utilisateur _utilisateur;
        public LigneReservationHebergement(ReservationHebergement reservationHebergement, Utilisateur utilisateur, Boolean colorTrueOrFalse)
        {
            InitializeComponent();
            this._reservationHebergement = reservationHebergement;
            this._utilisateur = utilisateur;
            labelPeriode.Text = "Du " + _reservationHebergement.DateDebut.ToString("dd-MM-yyyy") + " au " + _reservationHebergement.DateFin.ToString("dd-MM-yyyy");
            labelUsername.Text = _utilisateur.Nom + " " + _utilisateur.Prenom;
            labelCodeReservation.Text = _reservationHebergement.CodeReservation;
            labelPrix.Text = _reservationHebergement.Prix.ToString() + " €";
            if (colorTrueOrFalse)
            {
                this.BackColor = Color.FromArgb(228, 228, 228);
            }
        }
    }
}
