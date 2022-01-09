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
    public partial class ControlResponse : UserControl
    {
        List<Response> oldréponse;
        Avis avis;
        int idHebergement;
        modifHebergement ModifHebergement;
        private Utilisateur _utilisateur;
        public ControlResponse(List<Response> réponse, Avis avis, int idHebergement, modifHebergement modifHebergement, Utilisateur utilisateur)
        {
            InitializeComponent();
            this.oldréponse = réponse;
            this.avis = avis;
            this.idHebergement = idHebergement;
            this.ModifHebergement = modifHebergement;
            this._utilisateur = utilisateur;

            if (réponse.Count > 0)
            {
                ajoutResponse.Text = "Modifier";
                text.Text = réponse[0].Reponse;
            }
            else
            {
                supprimerResponse.Hide();
            }
        }

        private void ajoutResponse_Click(object sender, EventArgs e)
        {
            Avis Avis = new Avis();
            if (oldréponse.Count == 0)
            {
                int status = Avis.AjoutResponse(avis.IdAvis, _utilisateur.IdUtilisateur, text.Text);
                if (status == 0)
                {
                    MessageBox.Show("Echec de l'ajout !");

                    ModifHebergement.flow_avis.Controls.Clear();
                    ModifHebergement.tab_avis.Controls.RemoveByKey("ControlResponse");
                    ModifHebergement.flow_avis.Controls.Add(new AvisHebergement(avis, ModifHebergement, idHebergement, _utilisateur));

                    Response Response = new Response();
                    List<Response> réponse = Response.GetResponses(avis.IdAvis);

                    foreach (Response result in réponse)
                    {
                        ResponseHebergement customControl = new ResponseHebergement(result, ModifHebergement);
                        ModifHebergement.flow_avis.Controls.Add(customControl);
                    }
                    ModifHebergement.tab_avis.Controls.Add(new ControlResponse(réponse, avis, idHebergement, ModifHebergement, _utilisateur));
                }
                else if (status == 1)
                {
                    MessageBox.Show("Ajout réussi !");

                    ModifHebergement.flow_avis.Controls.Clear();
                    ModifHebergement.tab_avis.Controls.RemoveByKey("ControlResponse");
                    ModifHebergement.flow_avis.Controls.Add(new AvisHebergement(avis, ModifHebergement, idHebergement, _utilisateur));

                    Response Response = new Response();
                    List<Response> réponse = Response.GetResponses(avis.IdAvis);

                    foreach (Response result in réponse)
                    {
                        ResponseHebergement customControl = new ResponseHebergement(result, ModifHebergement);
                        ModifHebergement.flow_avis.Controls.Add(customControl);
                    }
                    ModifHebergement.tab_avis.Controls.Add(new ControlResponse(réponse, avis, idHebergement, ModifHebergement, _utilisateur));
                }
                else
                {
                    MessageBox.Show("Votre message ne peut pas être vide !");

                    ModifHebergement.flow_avis.Controls.Clear();
                    ModifHebergement.tab_avis.Controls.RemoveByKey("ControlResponse");
                    ModifHebergement.flow_avis.Controls.Add(new AvisHebergement(avis, ModifHebergement, idHebergement, _utilisateur));

                    Response Response = new Response();
                    List<Response> réponse = Response.GetResponses(avis.IdAvis);

                    foreach (Response result in réponse)
                    {
                        ResponseHebergement customControl = new ResponseHebergement(result, ModifHebergement);
                        ModifHebergement.flow_avis.Controls.Add(customControl);
                    }
                    ModifHebergement.tab_avis.Controls.Add(new ControlResponse(réponse, avis, idHebergement, ModifHebergement, _utilisateur));
                }
            }
            else
            {
                int status = Avis.UpdateResponse(oldréponse[0].IdResponse, text.Text);

                if (status == 0)
                {
                    MessageBox.Show("Echec de la modification !");

                    ModifHebergement.flow_avis.Controls.Clear();
                    ModifHebergement.tab_avis.Controls.RemoveByKey("ControlResponse");
                    ModifHebergement.flow_avis.Controls.Add(new AvisHebergement(avis, ModifHebergement, idHebergement, _utilisateur));

                    Response Response = new Response();
                    List<Response> réponse = Response.GetResponses(avis.IdAvis);

                    foreach (Response result in réponse)
                    {
                        ResponseHebergement customControl = new ResponseHebergement(result, ModifHebergement);
                        ModifHebergement.flow_avis.Controls.Add(customControl);
                    }
                    ModifHebergement.tab_avis.Controls.Add(new ControlResponse(réponse, avis, idHebergement, ModifHebergement, _utilisateur));
                }
                else if (status == 1)
                {
                    MessageBox.Show("Modification réussie !");

                    ModifHebergement.flow_avis.Controls.Clear();
                    ModifHebergement.tab_avis.Controls.RemoveByKey("ControlResponse");
                    ModifHebergement.flow_avis.Controls.Add(new AvisHebergement(avis, ModifHebergement, idHebergement, _utilisateur));

                    Response Response = new Response();
                    List<Response> réponse = Response.GetResponses(avis.IdAvis);

                    foreach (Response result in réponse)
                    {
                        ResponseHebergement customControl = new ResponseHebergement(result, ModifHebergement);
                        ModifHebergement.flow_avis.Controls.Add(customControl);
                    }
                    ModifHebergement.tab_avis.Controls.Add(new ControlResponse(réponse, avis, idHebergement, ModifHebergement, _utilisateur));
                }
                else
                {
                    MessageBox.Show("Votre message ne peut pas être vide !");

                    ModifHebergement.flow_avis.Controls.Clear();
                    ModifHebergement.tab_avis.Controls.RemoveByKey("ControlResponse");
                    ModifHebergement.flow_avis.Controls.Add(new AvisHebergement(avis, ModifHebergement, idHebergement, _utilisateur));

                    Response Response = new Response();
                    List<Response> réponse = Response.GetResponses(avis.IdAvis);

                    foreach (Response result in réponse)
                    {
                        ResponseHebergement customControl = new ResponseHebergement(result, ModifHebergement);
                        ModifHebergement.flow_avis.Controls.Add(customControl);
                    }
                    ModifHebergement.tab_avis.Controls.Add(new ControlResponse(réponse, avis, idHebergement, ModifHebergement, _utilisateur));
                }
            }
        }

        private void supprimerResponse_Click(object sender, EventArgs e)
        {
            Avis Avis = new Avis();
            MessageBox.Show(Avis.SuppressionResponse(oldréponse[0].IdResponse));

            ModifHebergement.flow_avis.Controls.Clear();
            ModifHebergement.tab_avis.Controls.RemoveByKey("ControlResponse");
            ModifHebergement.flow_avis.Controls.Add(new AvisHebergement(avis, ModifHebergement, idHebergement, _utilisateur));

            Response Response = new Response();
            List<Response> réponse = Response.GetResponses(avis.IdAvis);

            foreach (Response result in réponse)
            {
                ResponseHebergement customControl = new ResponseHebergement(result, ModifHebergement);
                ModifHebergement.flow_avis.Controls.Add(customControl);
            }
            ModifHebergement.tab_avis.Controls.Add(new ControlResponse(réponse, avis, idHebergement, ModifHebergement, _utilisateur));
        }

        private void retourResponse_Click(object sender, EventArgs e)
        {
            ModifHebergement.flow_avis.Controls.Clear();
            ModifHebergement.tab_avis.Controls.RemoveByKey("ControlResponse");

            Avis Avis = new Avis();
            List<Avis> allAvis = Avis.GetAllAvisHebergement(idHebergement);

            foreach (Avis avis in allAvis)
            {
                AvisHebergement customControl = new AvisHebergement(avis, ModifHebergement, idHebergement, _utilisateur);
                ModifHebergement.flow_avis.Controls.Add(customControl);
            }
        }
    }
}
