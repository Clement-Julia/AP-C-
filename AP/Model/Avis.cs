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

        private string _nom;
        public string Nom { get { return _nom; } set { _nom = value; } }

        private string _prénom;
        public string Prénom { get { return _prénom; } set { _prénom = value; } }

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

        public void InitialisationAvis(int id, DateTime date, int note, string commentaire, int idUtilisateur, int idHebergement, string nom, string prenom)
        {
            this.IdAvis = id;
            this.Date = date;
            this.Note = note;
            this.Commentaire = commentaire;
            this.IdUtilisateur = idUtilisateur;
            this.IdHebergement = idHebergement;
            this.Nom = nom;
            this.Prénom = prenom;
        }

        public List<Avis> GetAllAvisHebergement(int id)
        {
            _bdd.Open();
            List<Avis> Avis = new List<Avis>();
            MySqlCommand query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@idHebergement", id);
            query.CommandText = "SELECT idAvis, date, note, commentaire, idUtilisateur, idHebergement, nom, prenom FROM avis inner JOIN utilisateurs using (idutilisateur) where idHebergement = @idHebergement";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                Avis Avi = new Avis();
                Avi.InitialisationAvis(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetString(6), reader.GetString(7));
                Avis.Add(Avi);
            }
            _bdd.Close();
            return Avis;
        }
        
        public string AjoutResponse(int avis, int idHebergement, string text)
        {
            int idUser = 0;

            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@idHebergement", idHebergement);

            query.CommandText = "SELECT idUtilisateur from hebergement where idHebergement = @idHebergement";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                idUser = reader.GetInt32(0);
            }
            _bdd.Close();

            _bdd.Open();
            MySqlCommand query2 = _bdd.CreateCommand();
            query2.Parameters.AddWithValue("@idAvis", avis);
            query2.Parameters.AddWithValue("@idUtilisateur", idUser);
            query2.Parameters.AddWithValue("@reponse", text);

            query2.CommandText = "insert into avis_response(idAvis, idUtilisateur, reponse, date) values(@idAvis, @idUtilisateur, @reponse, now())";
            if (query2.ExecuteNonQuery() > 0)
            {
                _bdd.Close();
                return "Ajout réussi !";
            }
            else
            {
                _bdd.Close();
                return "Echec";
            }
        }

        public string UpdateResponse(int response, string text)
        {
            _bdd.Open();

            MySqlCommand query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@idResponse", response);
            query.Parameters.AddWithValue("@reponse", text);

            query.CommandText = "update avis_response set reponse = @reponse where idResponse = @idResponse";
            if (query.ExecuteNonQuery() > 0)
            {
                _bdd.Close();
                return "Ajout réussi !";
            }
            else
            {
                _bdd.Close();
                return "Echec";
            }
        }
    }
}
