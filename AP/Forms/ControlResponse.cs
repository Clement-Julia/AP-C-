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
        private int _idHebergement;
        private modifHebergement _modifHebergement;
        private Utilisateur _utilisateur;
        private Response _response;
        private Avis _avis;
        private ResponseHebergement _responseHebergement;

        public ControlResponse(Response response, Avis avis, int idHebergement, modifHebergement modifHebergement, Utilisateur utilisateur)
        {
            InitializeComponent();
            this._idHebergement = idHebergement;
            this._modifHebergement = modifHebergement;
            this._utilisateur = utilisateur;
            this._response = response;
            this._avis = avis;

            if (_response.IdAvis != 0)
            {
                ajoutResponse.Text = "Modifier";
                text.Text = _response.Reponse;
                this._responseHebergement = new ResponseHebergement(_response, _modifHebergement, _utilisateur);
                _modifHebergement.flow_avis.Controls.Add(_responseHebergement);
            }
            else
                supprimerResponse.Hide();
        }

        private void ajoutResponse_Click(object sender, EventArgs e)
        {
            if (text.Text != "")
            {
                if (_response.IdAvis == 0)
                {
                    _response = _avis.AjoutResponse(_avis.IdAvis, _utilisateur.IdUtilisateur, text.Text);
                    if (_response.IdAvis == 0)
                        MessageBox.Show("Echec de l'ajout !");
                    else
                    {
                        MessageBox.Show("Ajout réussi !");
                        this._responseHebergement = new ResponseHebergement(_response, _modifHebergement, _utilisateur);
                        _modifHebergement.flow_avis.Controls.Add(_responseHebergement);
                        ajoutResponse.Text = "Modifier";
                        supprimerResponse.Show();
                    }
                }
                else
                {
                    _response = _avis.UpdateResponse(_response, text.Text);

                    if (_response.Reponse == text.Text)
                    {
                        MessageBox.Show("Modification réussie !");
                        _responseHebergement.reponse.Text = _response.Reponse;
                    }
                    else
                        MessageBox.Show("Echec de la modification !");
                }
            }
            else
            {
                MessageBox.Show("Votre message ne peut pas être vide !");
            }
        }

        private void supprimerResponse_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_avis.SuppressionResponse(_response));
            _response = new Response();
            _modifHebergement.flow_avis.Controls.Remove(_responseHebergement);
            this._responseHebergement = new ResponseHebergement(_response, _modifHebergement, _utilisateur);
            ajoutResponse.Text = "Ajouter";
            supprimerResponse.Hide();
        }

        private void retourResponse_Click(object sender, EventArgs e)
        {
            _modifHebergement.flow_avis.Controls.Clear();
            _modifHebergement.tab_avis.Controls.RemoveByKey("ControlResponse");

            Hebergement Hebergement = new Hebergement(_idHebergement);

            foreach (Avis avis in Hebergement.ListAvis)
            {
                AvisHebergement customControl = new AvisHebergement(avis, _modifHebergement, _idHebergement, _utilisateur);
                _modifHebergement.flow_avis.Controls.Add(customControl);
            }
        }
    }
}
