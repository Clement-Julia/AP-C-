using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public AvisHebergement(Avis avis, modifHebergement ModifHebergement, int idHebergement, Utilisateur utilisateur)
        {
            InitializeComponent();
            this.nom.Text = avis.Nom;
            this.prénom.Text = avis.Prénom;
            this.rating.Text = avis.Note.ToString();
            this.commentaire.Text = avis.Commentaire;
            this.avis = avis;
            this.ModifHebergement = ModifHebergement;
            this.idHebergement = idHebergement;
            this._utilisateur = utilisateur;
        }

        private void link_avis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModifHebergement.flow_avis.Controls.Clear();
            ModifHebergement.flow_avis.Controls.Add(new AvisHebergement(avis, ModifHebergement, idHebergement, _utilisateur));
            Response Response = new Response();
            List<Response> réponse = Response.GetResponses(avis.IdAvis);

            foreach (Response result in réponse)
            {
                ResponseHebergement customControl = new ResponseHebergement(result, ModifHebergement);
                ModifHebergement.flow_avis.Controls.Add(customControl);
            }
            ControlResponse Panel = new ControlResponse(réponse, avis, idHebergement, ModifHebergement, _utilisateur);
            Panel.AutoScroll = true;
            ModifHebergement.tab_avis.Controls.Add(Panel);
            ModifHebergement.tab_avis.Tag = Panel;
            Panel.Dock = DockStyle.Bottom;
            Panel.BringToFront();
            Panel.Show();

            //ModifHebergement.tab_avis.Controls.Add(new ControlResponse(réponse, avis, idHebergement, ModifHebergement, _utilisateur));
        }
    }
}
