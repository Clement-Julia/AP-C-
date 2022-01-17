using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP.Model
{
    public class Avis : Bdd
    {

        private int _idAvis;
        public int IdAvis { get { return _idAvis; } set { _idAvis = value; } }

        private DateTime _date;
        public DateTime Date { get { return _date; } set { _date = value; } }

        private int _note;
        public int Note { get { return _note; } set { _note = value; } }

        private string _commentaire;
        public string Commentaire { get { return _commentaire; } set { _commentaire = value; } }

        private int _idUtilisateur;
        public int IdUtilisateur { get { return _idUtilisateur; } set { _idUtilisateur = value; } }

        private int _idHebergements;
        public int IdHebergement { get { return _idHebergements; } set { _idHebergements = value; } }

        public Avis(int IdAvis = 0)
        {
            if (IdAvis != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM avis WHERE idAvis = @idAvis";
                query.Parameters.AddWithValue("@idAvis", IdAvis);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdAvis = reader.GetInt32(0);
                    this.Date = reader.GetDateTime(1);
                    this.Note = reader.GetInt32(2);
                    this.Commentaire = reader.GetString(3);
                    this.IdUtilisateur = reader.GetInt32(4);
                    this.IdHebergement = reader.GetInt32(5);
                }
                _bdd.Close();
            }
        }

        public void InitialisationAvis(int id, DateTime date, int note, string commentaire, int idUtilisateur, int idHebergement)
        {
            this.IdAvis = id;
            this.Date = date;
            this.Note = note;
            this.Commentaire = commentaire;
            this.IdUtilisateur = idUtilisateur;
            this.IdHebergement = idHebergement;
        }

        public List<Avis> GetAllAvisHebergement(int id)
        {
            _bdd.Open();
            List<Avis> Avis = new List<Avis>();
            MySqlCommand query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@idHebergement", id);
            query.CommandText = "SELECT idAvis, date, note, commentaire, idUtilisateur, idHebergement FROM avis inner JOIN utilisateurs using (idutilisateur) where idHebergement = @idHebergement";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                Avis Avi = new Avis();
                Avi.InitialisationAvis(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5));
                Avis.Add(Avi);
            }
            _bdd.Close();
            return Avis;
        }
        
        public Response AjoutResponse(int avis, int idUser, string text)
        {
            Response Response = new Response();
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@idAvis", avis);
            query.Parameters.AddWithValue("@idUtilisateur", idUser);
            query.Parameters.AddWithValue("@reponse", text);

            query.CommandText = "insert into avis_response(idAvis, idUtilisateur, reponse, date) values(@idAvis, @idUtilisateur, @reponse, now())";
            if (query.ExecuteNonQuery() > 0)
            {
                _bdd.Close();
                _bdd.Open();
                query.CommandText = "SELECT * FROM avis_response WHERE idAvis = @idAvis";
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Response.InitialisationResponse(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetDateTime(4));
                }
                _bdd.Close();
                return Response;
            }
            else
            {
                _bdd.Close();
                return Response;
            }
        }

        public Response UpdateResponse(Response Response, string newReponse)
        {
            _bdd.Open();
            DateTime now = DateTime.Now;
            MySqlCommand query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@idResponse", Response.IdResponse);
            query.Parameters.AddWithValue("@date", now);
            query.Parameters.AddWithValue("@reponse", newReponse);

            query.CommandText = "UPDATE avis_response SET reponse = @reponse, date = @date WHERE idResponse = @idResponse";
            if (query.ExecuteNonQuery() > 0)
            {
                _bdd.Close();
                Response.Reponse = newReponse;
                Response.Date = now;
                return Response;
            }
            else
            {
                _bdd.Close();
                return Response;
            }
        }

        public string SuppressionResponse(Response Response)
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@idResponse", Response.IdResponse);
            query.CommandText = "DELETE FROM avis_response where idResponse = @idResponse";
            if (query.ExecuteNonQuery() > 0)
            {
                _bdd.Close();
                return "Suppression réussie !";
            }
            else
            {
                _bdd.Close();
                return "Echec";
            }
        }
    }
}
