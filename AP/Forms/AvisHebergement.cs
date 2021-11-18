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
        public AvisHebergement(Avis avis, modifHebergement ModifHebergement)
        {
            InitializeComponent();
            this.nom.Text = avis.Nom;
            this.prénom.Text = avis.Prénom;
            this.rating.Text = avis.Note.ToString();
            this.commentaire.Text = avis.Commentaire;
            this.avis = avis;
            this.ModifHebergement = ModifHebergement;
        }

        private void link_avis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModifHebergement.flow_avis.Controls.Clear();
            ModifHebergement.flow_avis.Controls.Add(new AvisHebergement(avis, ModifHebergement));
            Response Response = new Response();
            List<Response> réponse = Response.GetResponses(26);
            foreach (Response result in réponse)
            {
                ResponseHebergement customControl = new ResponseHebergement(result);
                ModifHebergement.flow_avis.Controls.Add(customControl);
            }
        }
    }
}
