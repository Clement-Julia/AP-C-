﻿using AP.Model;
using AP.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP.Forms
{
    public partial class HebergementInfos : Form
    {
        private Hebergement _hebergement { get; set; }
        private List<ReservationHebergement> _reservationHebergements { get; set; }
        public HebergementInfos(Hebergement hebergement)
        {
            InitializeComponent();
            this._hebergement = hebergement;
            ReservationHebergement reservationHebergement = new ReservationHebergement();
            this._reservationHebergements = reservationHebergement.GetReservationAVenir(_hebergement.IdHebergement);
        }

        private void HebergementInfos_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < _reservationHebergements.Count; i++)
            {
                Utilisateur utilisateur = new Utilisateur(_reservationHebergements[i].IdUtilisateur);
                if(i%2 == 0)
                {
                    flowLayoutPanelReservAVenir.Controls.Add(new LigneReservationHebergement(_reservationHebergements[i], utilisateur, false));
                } else
                {
                    flowLayoutPanelReservAVenir.Controls.Add(new LigneReservationHebergement(_reservationHebergements[i], utilisateur, true));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}