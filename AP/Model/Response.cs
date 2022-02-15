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

        private string _reponse;
        public string Reponse { get { return _reponse; } set { _reponse = value; } }

        private DateTime _date;
        public DateTime Date { get { return _date; } set { _date = value; } }

        private Utilisateur _utilisateur;
        public Utilisateur Utilisateur { get { return _utilisateur; } set { _utilisateur = value; } }

        public Response(int idAvis = 0)
        {
            if (idAvis != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM avis_response WHERE idAvis = @idAvis";
                query.Parameters.AddWithValue("@idAvis", idAvis);
                MySqlDataReader reader = query.ExecuteReader();
                int idUtilisateur = 0;
                while (reader.Read())
                {
                    this.IdResponse = reader.GetInt32(0);
                    this.IdAvis = reader.GetInt32(1);
                    idUtilisateur = reader.GetInt32(2);
                    this.Reponse = reader.GetString(3);
                    this.Date = reader.GetDateTime(4);
                }
                _bdd.Close();

                _bdd.Open();
                this.Utilisateur = new Utilisateur();
                query.CommandText = "SELECT utilisateurs.idUtilisateur, utilisateurs.email, utilisateurs.mdp, utilisateurs.nom, utilisateurs.prenom, utilisateurs.idRole, utilisateurs.acceptRGPD, utilisateurs.dateAcceptRGPD, utilisateurs.DoB, utilisateurs.token, roles.* FROM utilisateurs INNER JOIN roles USING(idRole) WHERE idUtilisateur = @idUtilisateur";
                query.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Role Role = new Role(reader.GetInt32(10), reader.GetString(11));
                    this.Utilisateur = new Utilisateur(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(6), reader.GetDateTime(7), reader.GetDateTime(8), Role);
                }
                _bdd.Close();
            }
        }

        public Response(int response, int id, string Reponses, DateTime date, Utilisateur utilisateur)
        {
            this.IdResponse = response;
            this.IdAvis = id;
            this.Reponse = Reponses;
            this.Date = date;
            this.Utilisateur = utilisateur;
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
                query.CommandText = "SELECT utilisateurs.idUtilisateur, utilisateurs.email, utilisateurs.mdp, utilisateurs.nom, utilisateurs.prenom, utilisateurs.idRole, utilisateurs.acceptRGPD, utilisateurs.dateAcceptRGPD, utilisateurs.DoB, utilisateurs.token, roles.*, avis_response.* FROM avis_response INNER JOIN utilisateurs USING(idUtilisateur) INNER JOIN roles USING(idRole) WHERE idAvis = @idAvis";
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Role Role = new Role(reader.GetInt32(10), reader.GetString(11));
                    Utilisateur Utilisateur = new Utilisateur(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(6), reader.GetDateTime(7), reader.GetDateTime(8), Role);
                    Response = new Response(reader.GetInt32(12), reader.GetInt32(13), reader.GetString(14), reader.GetDateTime(15), Utilisateur);
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
