using System;
using System.Drawing;
using System.Windows.Forms;
using AP.Model;

namespace AP.Forms
{
    public partial class AvisHebergement : UserControl
    {
        private Avis avis;
        private modifHebergement ModifHebergement;
        private int idHebergement;
        private Utilisateur _utilisateur;
        private Response _response;
        public Response Response { get { return _response; } set { _response = value; } }

        public AvisHebergement(Avis avis, modifHebergement ModifHebergement, int idHebergement, Utilisateur utilisateur, Boolean boolean = false)
        {
            InitializeComponent();
            this.avis = avis;
            this.ModifHebergement = ModifHebergement;
            this.idHebergement = idHebergement;
            this._utilisateur = utilisateur;

            Utilisateur user = new Utilisateur(avis.Utilisateur.IdUtilisateur);

            nom.Text = user.Nom + " " + user.Prenom;
            rating.Text = avis.Note.ToString();
            commentaire.Text = avis.Commentaire;
            labelDate.Text = "Le " + avis.Date.ToShortDateString();

            _response = new Response(avis.IdAvis);

            if (_response.IdAvis != 0)
            {
                panelNonRepondu.Hide();
                BtnReponse.Text = "Voir réponse";
                BtnReponse.BackColor = Color.FromArgb(192, 255, 192);
            } else
            {
                panelRepondu.Hide();
                BtnReponse.Text = "Répondre";
                BtnReponse.BackColor = Color.FromArgb(255, 224, 192);
            }

            if (boolean)
                BtnReponse.Hide();

        }

        private void BtnReponse_Click(object sender, EventArgs e)
        {
            ModifHebergement.tab_avis.Controls.RemoveByKey("ControlResponse");
            ModifHebergement.flow_avis.Controls.Clear();
            ModifHebergement.flow_avis.Controls.Add(new AvisHebergement(avis, ModifHebergement, idHebergement, _utilisateur, true));
            ControlResponse Panel = new ControlResponse(_response, avis, idHebergement, ModifHebergement, _utilisateur);
            Panel.AutoScroll = true;
            ModifHebergement.tab_avis.Controls.Add(Panel);
            ModifHebergement.tab_avis.Tag = Panel;
            Panel.Dock = DockStyle.Bottom;
            Panel.BringToFront();
            Panel.Show();
        }
    }
}
