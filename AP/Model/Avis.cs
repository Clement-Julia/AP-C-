using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

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

        private Utilisateur _utilisateur { get; set; }
        public Utilisateur Utilisateur { get { return _utilisateur; } set { _utilisateur = value; } }

        private Hebergement _hebergement { get; set; }
        public Hebergement Hebergement { get { return _hebergement; } set { _hebergement = value; } }

        public Avis(int IdAvis = 0)
        {
            if (IdAvis != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM avis WHERE idAvis = @idAvis";
                query.Parameters.AddWithValue("@idAvis", IdAvis);
                MySqlDataReader reader = query.ExecuteReader();
                int idUtilisateur = 0;
                int idHebergement = 0;
                while (reader.Read())
                {
                    this.IdAvis = reader.GetInt32(0);
                    this.Date = reader.GetDateTime(1);
                    this.Note = reader.GetInt32(2);
                    this.Commentaire = reader.GetString(3);
                    idUtilisateur = reader.GetInt32(4);
                    idHebergement = reader.GetInt32(5);
                }
                _bdd.Close();

                _bdd.Open();
                this.Utilisateur = new Utilisateur();
                query.CommandText = "SELECT utilisateurs.idUtilisateur, utilisateurs.email, utilisateurs.mdp, utilisateurs.nom, utilisateurs.prenom, utilisateurs.idRole, utilisateurs.acceptRGPD, utilisateurs.dateAcceptRGPD, utilisateurs.DoB, utilisateurs.token, roles.* FROM utilisateurs INNER JOIN roles USING(idRole) WHERE idUtilisateur = @idUtilisateur";
                query.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                while (reader.Read())
                {
                    Role Role = new Role(reader.GetInt32(10), reader.GetString(11));
                    this.Utilisateur = new Utilisateur(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(6), reader.GetDateTime(7), reader.GetDateTime(8), Role);
                }
                _bdd.Close();
                
                _bdd.Open();
                this.Hebergement = new Hebergement();
                query.CommandText = "SELECT hebergement.*, villes.*, regions.*, utilisateurs.idUtilisateur, utilisateurs.email, utilisateurs.mdp, utilisateurs.nom, utilisateurs.prenom, utilisateurs.idRole, utilisateurs.acceptRGPD, utilisateurs.dateAcceptRGPD, utilisateurs.DoB, utilisateurs.token FROM hebergement INNER JOIN villes USING(idVille) INNER JOIN utilisateurs USING(idUtilisateur) INNER JOIN regions USING(idRegion) WHERE idHebergement = @idHebergement";
                query.Parameters.AddWithValue("@idHebergement", idHebergement);
                while (reader.Read())
                {
                    string uuid = "";
                    if (!reader.IsDBNull(reader.GetOrdinal("uuid"))) { uuid = reader.GetString(8); } else { uuid = ""; }

                    Region Region = new Region(reader.GetInt32(19), reader.GetString(20), reader.GetFloat(21), reader.GetFloat(22), reader.GetInt32(23), reader.GetString(24));
                    Ville Ville = new Ville(reader.GetInt32(12), reader.GetString(13), reader.GetString(14), reader.GetFloat(15), reader.GetFloat(16), reader.GetString(18), reader.GetString(18), Region);
                    Role Role = new Role(reader.GetInt32(35), reader.GetString(36));
                    Utilisateur Utilisateur = new Utilisateur(reader.GetInt32(25), reader.GetString(26), reader.GetString(27), reader.GetString(28), reader.GetString(29), reader.GetBoolean(31), reader.GetDateTime(32), reader.GetDateTime(33), Role);

                    this.Hebergement = new Hebergement(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDouble(5), reader.GetDouble(6), reader.GetDecimal(7), uuid, reader.GetDateTime(10), reader.GetBoolean(11), Ville, Utilisateur);
                }
                _bdd.Close();
            }
        }

        public Avis(int id, DateTime date, int note, string commentaire, Utilisateur utilisateur, Hebergement hebergement)
        {
            this.IdAvis = id;
            this.Date = date;
            this.Note = note;
            this.Commentaire = commentaire;
            this.Utilisateur = utilisateur;
            this.Hebergement = hebergement;
        }

    }
}
