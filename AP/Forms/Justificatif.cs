using AP.Model;
using System;
using System.Windows.Forms;

namespace AP.Forms
{
    public partial class Justificatif : Form
    {
        Utilisateur utilisateur { get; set; }
        public Justificatif(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime1 = dateTimePicker1.Value;
            DateTime dateTime2 = dateTimePicker2.Value;
            PrevisualisationPDF Panel = new PrevisualisationPDF(dateTime1, dateTime2, utilisateur);
            Panel.TopLevel = false;
            Panel.FormBorderStyle = FormBorderStyle.None;
            Panel.AutoScroll = true;
            this.Controls.Add(Panel);
            this.Tag = Panel;
            Panel.Dock = DockStyle.Fill;
            Panel.BringToFront();
            Panel.Show();
        }
    }
}
