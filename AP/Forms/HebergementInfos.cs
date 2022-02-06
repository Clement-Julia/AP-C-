using AP.Model;
using AP.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AP.Forms
{
    public partial class HebergementInfos : Form
    {
        private Hebergement _hebergement { get; set; }
        private ReservationHebergement _reservationEnCours { get; set; }
        private List<ReservationHebergement> _reservationHebergements { get; set; }
        public HebergementInfos(Hebergement hebergement)
        {
            InitializeComponent();
            this._hebergement = hebergement;
            ReservationHebergement reservationHebergement = new ReservationHebergement();
            this._reservationHebergements = reservationHebergement.GetReservationAVenir(_hebergement.IdHebergement);
            this._reservationEnCours = reservationHebergement.GetReservationEnCours(_hebergement.IdHebergement);
        }

        private void HebergementInfos_Load(object sender, EventArgs e)
        {
            flowLayoutPanelReservAVenir.WrapContents = false;
            flowLayoutPanelAvis.WrapContents = false;

            // Remplissage titre
            labelTitreHebergement.Text = _hebergement.Libelle;

            // Remplissage Infos Hébergement
            Ville Ville = new Ville(_hebergement.Ville.IdVille);
            labelDescription.Text = _hebergement.Description;
            labelDescriptionPrix.Text = "Prix : " + _hebergement.Prix.ToString() + " € / nuit";
            labelDescriptionAdresse.Text = "Adresse : " + _hebergement.Adresse + " \n" + Ville.CodePostal + " " + Ville.Libelle;

            // Remplissage des gains
            int[] infosGains = _hebergement.GetInfosGains();
            labelGain1M.Text = infosGains[0].ToString() + " €";
            labelGain3M.Text = infosGains[1].ToString() + " €";
            labelGain6M.Text = infosGains[2].ToString() + " €";
            labelGain1A.Text = infosGains[3].ToString() + " €";
            labelGainAll.Text = infosGains[4].ToString() + " €";

            // Remplissage des deux premiers panels (Infos année en cours et tout confondu)
            int[] infosTOYear = _hebergement.GetInfosAboutTOYear();
            int[] infosTOAll = _hebergement.GetInfosAboutTOAll();

            labelTotalNuitsYear.Text = infosTOYear[0].ToString();
            labelNuitsReserveesYear.Text = infosTOYear[1].ToString();
            labelTOYear.Text = infosTOYear[2].ToString() + "%";
            labelReservCetteAnnee.Text = infosTOYear[3].ToString();

            labelTotalNuitsAll.Text = infosTOAll[0].ToString();
            labelNuitsReserveesAll.Text = infosTOAll[1].ToString();
            labelTOAll.Text = infosTOAll[2].ToString() + "%";
            labelReservAll.Text = infosTOAll[3].ToString();


            // Infos panel réservation en cours
            if (_reservationEnCours.IdReservationHebergement != 0)
            {
                panelPasDeReservEnCours.Hide();

                labelReservEnCoursPeriode.Text = "Du " + _reservationEnCours.DateDebut.ToString("dd-MM-yyyy") + " au " + _reservationEnCours.DateFin.ToString("dd-MM-yyyy");
                labelReservEnCoursUsername.Text = _reservationEnCours.Utilisateur.Nom + " " + _reservationEnCours.Utilisateur.Prenom;
                labelReservEnCoursCodeReserv.Text = _reservationEnCours.CodeReservation;
                labelReservEnCoursPrix.Text = _reservationEnCours.Prix.ToString() + " €";
            }
            else
            {
                panelPasDeReservEnCours.Show();
            }

            // Infos réservation à venir
            for(int i = 0; i < _reservationHebergements.Count; i++)
            {
                // Utilisateur utilisateur = new Utilisateur(_reservationHebergements[i].IdUtilisateur);
                // Le modulo permet d'alterner le troisième paramètre qui défini la couleur de fond de la ligne
                if(i%2 == 0)
                {
                    flowLayoutPanelReservAVenir.Controls.Add(new LigneReservationHebergement(_reservationHebergements[i], _reservationHebergements[i].Utilisateur, false));
                } else
                {
                    flowLayoutPanelReservAVenir.Controls.Add(new LigneReservationHebergement(_reservationHebergements[i], _reservationHebergements[i].Utilisateur, true));
                }
            }

            // Infos Avis
            for (int i = 0; i < _hebergement.ListAvis.Count; i++)
            {
                // Utilisateur User = new Utilisateur(_hebergement.ListAvis[i].IdUtilisateur);
                if (i % 2 == 0)
                {
                    flowLayoutPanelAvis.Controls.Add(new LigneAvis(_hebergement.ListAvis[i], _hebergement.Utilisateur, false));
                }
                else
                {
                    flowLayoutPanelAvis.Controls.Add(new LigneAvis(_hebergement.ListAvis[i], _hebergement.Utilisateur, true));
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
