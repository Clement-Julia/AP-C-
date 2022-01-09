using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP.Model
{
    public class Response : Bdd
    {

        private int _idResponse;
        public int IdResponse { get { return _idResponse; } set { _idResponse = value; } }

        private int _idAvis;
        public int IdAvis { get { return _idAvis; } set { _idAvis = value; } }

        private int _idUtilisateur;
        public int IdUtilisateur { get { return _idUtilisateur; } set { _idUtilisateur = value; } }

        private string _reponse;
        public string Reponse { get { return _reponse; } set { _reponse = value; } }

        private DateTime _date;
        public DateTime Date { get { return _date; } set { _date = value; } }

        private string _nom;
        public string Nom { get { return _nom; } set { _nom = value; } }

        private string _prénom;
        public string Prénom { get { return _prénom; } set { _prénom = value; } }


        public Response(int IdResponse = 0)
        {
            if (IdResponse != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM avis_response WHERE idResponse = @idResponse";
                query.Parameters.AddWithValue("@idResponse", IdResponse);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdResponse = reader.GetInt32(0);
                    this.IdAvis = reader.GetInt32(0);
                    this.IdUtilisateur = reader.GetInt32(2);
                    this.Reponse = reader.GetString(3);
                    this.Date = reader.GetDateTime(4);
                }
                _bdd.Close();
            }
        }

        public void InitialisationResponse(int response, int id, DateTime date, int idUtilisateur, string Reponses, string nom, string prénom)
        {
            this.IdResponse = response;
            this.IdAvis = id;
            this.IdUtilisateur = idUtilisateur;
            this.Reponse = Reponses;
            this.Date = date;
            this.Nom = nom;
            this.Prénom = prénom;
        }

        public List<Response> GetResponses(int id)
        {
            _bdd.Open();
            List<Response> Responses = new List<Response>();
            MySqlCommand query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@idAvis", id);
            query.CommandText = "SELECT idResponse, idAvis, avis_response.idUtilisateur, reponse, date, nom, prenom FROM avis_response inner Join utilisateurs USING(idUtilisateur) where avis_response.idAvis = @idAvis";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                Response Response = new Response();
                Response.InitialisationResponse(reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTime(4), reader.GetInt32(2), reader.GetString(3), reader.GetString(5), reader.GetString(6));
                Responses.Add(Response);
            }
            _bdd.Close();
            return Responses;
        }
    }
}
