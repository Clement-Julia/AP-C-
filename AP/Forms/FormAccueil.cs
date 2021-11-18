﻿using AP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP.Forms
{
    public partial class FormAccueil : Form
    {
        public Utilisateur Utilisateur { get; set; }
        public FormAccueil(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.Utilisateur = utilisateur;

            // Initialisation des données
            int totalReservations = Utilisateur.GetNbTotalReservations();
            LabelTotalReservations.Text = "Vous totalisez " + totalReservations.ToString();
            if(totalReservations < 2) { LabelTotalReservations.Text += " réservation"; } else { LabelTotalReservations.Text += " réservations"; }
            int reservationsEnCours = Utilisateur.GetNbTotalReservationsEnCours();
            LabelReservationsEnCours.Text = "Vous avez " + reservationsEnCours.ToString();
            if (reservationsEnCours < 2) { LabelReservationsEnCours.Text += " réservation en cours"; } else { LabelReservationsEnCours.Text += " réservations en cours"; }
            int reservationAVenir = Utilisateur.GetNbTotalReservationsAVenir();
            LabelReservationsAVenir.Text = "Vous avez " + reservationAVenir.ToString();
            if (reservationAVenir < 2) { LabelReservationsAVenir.Text += " réservation à venir"; } else { LabelReservationsAVenir.Text += " réservations à venir"; }
            int GainTotal = Utilisateur.GetGainsTotal();
            LabelGainTotal.Text = GainTotal.ToString() + " €";
            int GainPrevisionel = Utilisateur.GetGainsPrevisionel();
            LabelGainsPrevisonel.Text = GainPrevisionel.ToString() + " €";
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.LightSeaGreen, 15),
                            this.DisplayRectangle);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.LightSeaGreen, 15),
                            this.DisplayRectangle);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.LightSeaGreen, 15),
                            this.DisplayRectangle);
        }

        private void FormAccueil_Shown(object sender, EventArgs e)
        {
            CPBhebergements.Value = 0;
            CPBhebergements.Minimum = 0;
            int donnee = Utilisateur.GetNbHebergements();
            CPBhebergements.Maximum = donnee + 2;
            for (int i = 0; i <= donnee; i++)
            {
                Thread.Sleep(5);
                CPBhebergements.Value = i;
                CPBhebergements.Update();
            }
            CPBhebergements.Text = donnee + " Hébergement";
            if (donnee > 1)
                CPBhebergements.Text += "s";
        }


    }
}