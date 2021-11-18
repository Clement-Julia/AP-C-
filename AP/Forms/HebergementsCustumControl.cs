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
            //FlowLayoutPanel parentPanel = (this.Parent as FormHebergements).PanelHebergements as FlowLayoutPanel;
            //parentPanel.Controls.Add(new HebergementInfos());


            //HebergementInfos MyForm = new HebergementInfos();
            //this.FormHeber.PanelHebergements.Controls.Clear();
            //MyForm.TopLevel = false;
            //MyForm.FormBorderStyle = FormBorderStyle.None;
            //MyForm.Dock = DockStyle.Fill;
            //this.FormHeber.PanelHebergements.Controls.Add(MyForm);
            //this.FormHeber.PanelHebergements.Tag = MyForm;
            //MyForm.BringToFront();
            //MyForm.Show();

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
