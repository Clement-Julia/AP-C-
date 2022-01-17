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

    }
}
