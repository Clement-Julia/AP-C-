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

namespace AP.Forms
{
    public partial class HebergementsCustumControl : UserControl
    {
        public Hebergement Hebergement { get; set; }
        public FormHebergements FormHeber { get; set; }
        public HebergementsCustumControl(Hebergement hebergement, FormHebergements formHebergements)
        {
            InitializeComponent();
            this.Hebergement = hebergement;
            this.FormHeber = formHebergements;
            LabelNomHebergement.Text = Hebergement.Libelle;
            LabelNbReservationEnCours.Text = Hebergement.GetNombreReservationEnCours();
            LabelNbReservationAVenir.Text = Hebergement.GetNombreReservationAVenir();
        }

        public HebergementsCustumControl()
        {
            InitializeComponent();
        }


        private void HebergementsCustumControl_Load(object sender, EventArgs e)
        {

        }

        private void BtnInfos_Click(object sender, EventArgs e)
        {

            HebergementInfos Panel = new HebergementInfos(Hebergement);
            Panel.TopLevel = false;
            Panel.FormBorderStyle = FormBorderStyle.None;
            Panel.AutoScroll = true;
            FormHeber.Controls.Add(Panel);
            FormHeber.Tag = Panel;
            Panel.Dock = DockStyle.Fill;
            Panel.BringToFront();
            Panel.Show();

        }

    }
}
