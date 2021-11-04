using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.Model
{
    public class Utilisateur : Http
    {
        private int _idUtilisateur;
        public int IdUtilisateur { get { return _idUtilisateur; } set { _idUtilisateur = value; } }

        private string _email;
        public string Email { get { return _email; } set { _email = value; } }

        private string _mdp;
        public string Mdp { get { return _mdp; } set { _mdp = value; } }

        private string _nom;
        public string Nom { get { return _nom; } set { _nom = value; } }

        private string _prenom;
        public string Prenom { get { return _prenom; } set { _prenom = value; } }

        private int _idRole;
        public int IdRole { get { return _idRole; } set { _idRole = value; } }

        private bool _acceptRGPD;
        public bool AcceptRGPD { get { return _acceptRGPD; } set { _acceptRGPD = value; } }

        private string _dateAcceptRGPD;
        public string DateAcceptRGPD { get { return _dateAcceptRGPD; } set { _dateAcceptRGPD = value; } }

        private string _dateOfBirth;
        public string DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

        public Utilisateur(int IdUtilisateur = 0)
        {
            if(IdUtilisateur != 0)
            {
                _http.Open();
                MySqlCommand query = _http.CreateCommand();
                query.CommandText = "SELECT * FROM utilisateurs WHERE idUtilisateur = @idUtilisateur";
                query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdUtilisateur = reader.GetInt32(0);
                    this.Email = reader.GetString(1);
                    this.Mdp = reader.GetString(2);
                    this.Nom = reader.GetString(3);
                    this.Prenom = reader.GetString(4);
                    this.IdRole = reader.GetInt32(5);
                    this.AcceptRGPD = reader.GetBoolean(6);
                    this.DateAcceptRGPD = reader.GetString(7);
                    this.DateOfBirth = reader.GetString(8);
                }
                _http.Close();
            }
        }

        public Utilisateur(string email)
        {
            _http.Open();
            MySqlCommand query = _http.CreateCommand();
            query.CommandText = "SELECT * FROM utilisateurs WHERE email = @email";
            query.Parameters.AddWithValue("@email", email);
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                this.IdUtilisateur = reader.GetInt32(0);
                this.Email = reader.GetString(1);
                this.Mdp = reader.GetString(2);
                this.Nom = reader.GetString(3);
                this.Prenom = reader.GetString(4);
                this.IdRole = reader.GetInt32(5);
                this.AcceptRGPD = reader.GetBoolean(6);
                this.DateAcceptRGPD = reader.GetString(7);
                this.DateOfBirth = reader.GetString(8);
            }
            _http.Close();
        }

        public void InitialisationUtilisateur(int id, string email, string mdp, string nom, string prenom, int idRole, bool acceptRGPD, string dateAcceptRGPD, string dateOfBirth)
        {
            this.IdUtilisateur = id;
            this.Email = email;
            this.Mdp = mdp;
            this.Nom = nom;
            this.Prenom = prenom;
            this.IdRole = idRole;
            this.AcceptRGPD = acceptRGPD;
            this.DateAcceptRGPD = dateAcceptRGPD;
            this.DateOfBirth = dateOfBirth;
        }

        public void GetAllHebergements()
        {
            _http.Open();
            MySqlCommand query = _http.CreateCommand();
            query.CommandText = "SELECT * FROM hebergement WHERE idUtilisateur = @idUtilisateur";
        }

    }
}
