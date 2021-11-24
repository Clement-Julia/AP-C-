using AP.Model;
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

            Avis Avis = new Avis();
            List<Avis> listAvis = Avis.GetAllAvisHebergement(_hebergement.IdHebergement);

            for (int i = 0; i < listAvis.Count; i++)
            {
                Utilisateur User = new Utilisateur(listAvis[i].IdUtilisateur);
                if (i % 2 == 0)
                {
                    flowLayoutPanelAvis.Controls.Add(new LigneAvis(listAvis[i], User, false));
                }
                else
                {
                    flowLayoutPanelAvis.Controls.Add(new LigneAvis(listAvis[i], User, true));
                }
            }
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
