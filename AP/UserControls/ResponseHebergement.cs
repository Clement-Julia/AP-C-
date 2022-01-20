using System.Windows.Forms;
using AP.Model;

namespace AP.Forms
{
    public partial class ResponseHebergement : UserControl
    {
        private Response _response;
        private Utilisateur _utilisateur;
        public ResponseHebergement(Response response = null, Utilisateur utilisateur = null)
        {
            InitializeComponent();
            this._response = response;
            this._utilisateur = utilisateur;
            nom.Text = _utilisateur.Nom + " " + _utilisateur.Prenom;
            reponse.Text = _response.Reponse;
            labelDate.Text = _response.Date.ToShortDateString();
        }
    }
}
