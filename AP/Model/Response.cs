using MySql.Data.MySqlClient;
using System;

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

        public Response(int idAvis = 0)
        {
            if (idAvis != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM avis_response WHERE idAvis = @idAvis";
                query.Parameters.AddWithValue("@idAvis", idAvis);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdResponse = reader.GetInt32(0);
                    this.IdAvis = reader.GetInt32(1);
                    this.IdUtilisateur = reader.GetInt32(2);
                    this.Reponse = reader.GetString(3);
                    this.Date = reader.GetDateTime(4);
                }
                _bdd.Close();
            }
        }

        public void InitialisationResponse(int response, int id, int idUtilisateur, string Reponses, DateTime date)
        {
            this.IdResponse = response;
            this.IdAvis = id;
            this.IdUtilisateur = idUtilisateur;
            this.Reponse = Reponses;
            this.Date = date;
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
