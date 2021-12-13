using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AP.Model;

namespace AP.Forms
{
    public partial class Home : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private Utilisateur _utilisateur;
        public Utilisateur Utilisateur { get { return _utilisateur; } set { _utilisateur = value ;} }

        private Form activeForm = null;

        public Home(Utilisateur utilisateur)
        {
            InitializeComponent();
            // accueilCustomControl1.BringToFront();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnAccueil.Height;
            PnlNav.Top = BtnAccueil.Top;
            PnlNav.Left = BtnAccueil.Left;
            BtnAccueil.BackColor = Color.FromArgb(32, 178, 170);
            this.Utilisateur = utilisateur;
            LabelUserName.Text = Utilisateur.Nom + " " + Utilisateur.Prenom;
            LabelMembreDepuis.Text = "Membre depuis " + Utilisateur.DateAcceptRGPD.ToString("dd-MM-yyyy");

            openChildForm(new FormAccueil(utilisateur));
        }

        private void BtnAccueil_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAccueil.Height;
            PnlNav.Top = BtnAccueil.Top;
            PnlNav.Left = BtnAccueil.Left;
            openChildForm(new FormAccueil(Utilisateur));

        }

        private void BtnHebergements_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnHebergements.Height;
            PnlNav.Top = BtnHebergements.Top;
            openChildForm(new FormHebergements(Utilisateur));

        }

        private void BtnFiscalite_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnFiscalite.Height;
            PnlNav.Top = BtnFiscalite.Top;
            openChildForm(new Justificatif(Utilisateur));
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnOptions.Height;
            PnlNav.Top = BtnOptions.Top;
            openChildForm(new test2());
        }

        private void BtnAccueil_Leave(object sender, EventArgs e)
        {
            BtnAccueil.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void BtnHebergements_Leave(object sender, EventArgs e)
        {
            BtnHebergements.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void BtnFiscalite_Leave(object sender, EventArgs e)
        {
            BtnFiscalite.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void BtnOptions_Leave(object sender, EventArgs e)
        {
            BtnOptions.BackColor = Color.FromArgb(32, 178, 170);
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelAccueil.Controls.Add(childForm);
            PanelAccueil.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnTest.Height;
            PnlNav.Top = BtnTest.Top;
            openChildForm(new AjoutHebergement(Utilisateur));
        }
    }
}

