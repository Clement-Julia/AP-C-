using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace AP.Model
{
    public class Utilisateur : Bdd
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

        private bool _acceptRGPD;
        public bool AcceptRGPD { get { return _acceptRGPD; } set { _acceptRGPD = value; } }

        private DateTime _dateAcceptRGPD;
        public DateTime DateAcceptRGPD { get { return _dateAcceptRGPD; } set { _dateAcceptRGPD = value; } }

        private DateTime _dateOfBirth;
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

        private Role _role;
        public Role Role { get { return _role; } set { _role = value; } }

        private List<Hebergement> _listHebergements = new List<Hebergement>();

        public List<Hebergement> ListHebergements { get { return _listHebergements; } set { _listHebergements = value; } }

        public Utilisateur(int IdUtilisateur = 0)
        {
            if(IdUtilisateur != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT utilisateurs.idUtilisateur, utilisateurs.email, utilisateurs.mdp, utilisateurs.nom, utilisateurs.prenom, utilisateurs.idRole, utilisateurs.acceptRGPD, utilisateurs.dateAcceptRGPD, utilisateurs.DoB, utilisateurs.token, roles.* FROM utilisateurs INNER JOIN roles USING(idRole) WHERE idUtilisateur = @idUtilisateur";
                query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdUtilisateur = reader.GetInt32(0);
                    this.Email = reader.GetString(1);
                    this.Mdp = reader.GetString(2);
                    this.Nom = reader.GetString(3);
                    this.Prenom = reader.GetString(4);
                    this.Role = new Role(reader.GetInt32(10), reader.GetString(11));
                    this.AcceptRGPD = reader.GetBoolean(6);
                    this.DateAcceptRGPD = reader.GetDateTime(7);
                    this.DateOfBirth = reader.GetDateTime(8);
                }
                _bdd.Close();

                GetAllHebergements();
            }
        }

        public Utilisateur(string email)
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT * FROM utilisateurs WHERE email = @email";
            query.Parameters.AddWithValue("@email", email);
            MySqlDataReader reader = query.ExecuteReader();
            int idRole = 0;
            while (reader.Read())
            {
                this.IdUtilisateur = reader.GetInt32(0);
                this.Email = reader.GetString(1);
                this.Mdp = reader.GetString(2);
                this.Nom = reader.GetString(3);
                this.Prenom = reader.GetString(4);
                idRole = reader.GetInt32(5);
                this.AcceptRGPD = reader.GetBoolean(6);
                this.DateAcceptRGPD = reader.GetDateTime(7);
                this.DateOfBirth = reader.GetDateTime(8);
            }
            _bdd.Close();

            this.Role = new Role(idRole);

            GetAllHebergements();
        }

        public Utilisateur(int idUtilisateur, string email, string mdp, string nom, string prenom, Boolean acceptRGPD, DateTime dateAcceptRGPD, DateTime DoB, Role role)
        {
            this.IdUtilisateur = idUtilisateur;
            this.Email = email;
            this.Mdp = mdp;
            this.Nom = nom;
            this.Prenom = prenom;
            this.AcceptRGPD = acceptRGPD;
            this.DateAcceptRGPD = dateAcceptRGPD;
            this.DateOfBirth = DoB;
            this.Role = role;
        }

        public bool Inscription(string email, string mdp, string nom, string prenom, bool acceptRGPD, DateTime DoB)
        {
            _bdd.Open();
            MySqlCommand command = _bdd.CreateCommand();
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@mdp", BCrypt.Net.BCrypt.HashPassword(mdp));
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@idRole", 3);
            command.Parameters.AddWithValue("@acceptRGPD", acceptRGPD);
            command.Parameters.AddWithValue("@dateAcceptRGPD", DateTime.Now);
            command.Parameters.AddWithValue("@DoB", DoB);
            command.CommandText = "INSERT INTO utilisateurs (email, mdp, nom, prenom, idRole, acceptRGPD, dateAcceptRGPD, DoB) VALUES (@email , @mdp , @nom , @prenom , @idRole , @acceptRGPD , @dateAcceptRGPD, @DoB)";

            if (command.ExecuteNonQuery() > 0)
            {
                _bdd.Close();
                return true;
            }
            else
            {
                _bdd.Close();
                return false;
            }
        }

        public List<Hebergement> GetAllHebergements()
        {
            _listHebergements = new List<Hebergement>();
            List<int> idHebergements = new List<int>();
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT idHebergement FROM hebergement WHERE idUtilisateur = @idUtilisateur AND actif = 1";
            query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                idHebergements.Add(reader.GetInt32(0));
            }
            _bdd.Close();

            foreach(int idHebergement in idHebergements)
            {
                _listHebergements.Add(new Hebergement(idHebergement));
            }

            return _listHebergements;
        }

        public int GetNbTotalReservations()
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT COUNT(*) FROM reservations_hebergement INNER JOIN hebergement USING(idHebergement) WHERE hebergement.idUtilisateur = @idUtilisateur";
            query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
            MySqlDataReader reader = query.ExecuteReader();
            int quantite = 0;
            while (reader.Read())
            {
                quantite = reader.GetInt32(0);
            }
            _bdd.Close();

            return quantite;
            
        }
        
        public int GetNbTotalReservationsEnCours()
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT COUNT(idReservationHebergement) FROM reservations_hebergement INNER JOIN hebergement USING(idHebergement) INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage WHERE hebergement.idUtilisateur = @idUtilisateur AND is_building = 0 AND NOW() BETWEEN dateDebut AND dateFin";
            query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
            MySqlDataReader reader = query.ExecuteReader();
            int quantite = 0;
            while (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("COUNT(idReservationHebergement)"))) { quantite = reader.GetInt32(0); } else { quantite = 0; }
            }
            _bdd.Close();

            return quantite;
        }
        
        public int GetNbTotalReservationsAVenir()
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT COUNT(idReservationHebergement) FROM reservations_hebergement INNER JOIN hebergement USING(idHebergement) INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage WHERE hebergement.idUtilisateur = @idUtilisateur AND is_building = 0 AND NOW() < dateDebut";
            query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
            MySqlDataReader reader = query.ExecuteReader();
            int quantite = 0;
            while (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("COUNT(idReservationHebergement)"))) { quantite = reader.GetInt32(0); } else { quantite = 0; }
            }
            _bdd.Close();

            return quantite;
            
        }

        public int GetGainsTotal()
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT SUM(reservations_hebergement.prix) as gains FROM reservations_hebergement INNER JOIN hebergement USING(idHebergement) INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage WHERE hebergement.idUtilisateur = @idUtilisateur AND is_building = 0 AND NOW() > dateFin";
            query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
            MySqlDataReader reader = query.ExecuteReader();
            int Gains = 0;
            while (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("gains"))) { Gains = reader.GetInt32(0); } else { Gains = 0; }
            }
            _bdd.Close();

            return Gains;
        }

        public int GetGainsPrevisionel()
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT SUM(reservations_hebergement.prix) as gainsPrevisionnels FROM reservations_hebergement INNER JOIN hebergement USING(idHebergement) INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage WHERE hebergement.idUtilisateur = @idUtilisateur AND is_building = 0 AND NOW() < dateFin";
            query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
            MySqlDataReader reader = query.ExecuteReader();
            int GainsPrevisionnels = 0;
            while (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("gainsPrevisionnels"))) { GainsPrevisionnels = reader.GetInt32(0); } else { GainsPrevisionnels = 0; }
            }
            _bdd.Close();

            return GainsPrevisionnels;
        }

        public List<ReservationHebergement> GetReservationsBetween(DateTime one, DateTime two)
        {
            List<ReservationHebergement> reservationHebergements = new List<ReservationHebergement>();

            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT hebergement.*, villes.*, regions.*, u2.idUtilisateur, u2.email, u2.mdp, u2.nom, u2.prenom, u2.idRole, u2.acceptRGPD, u2.dateAcceptRGPD, u2.DoB, u2.token, ru2.idRole, ru2.libelle, reservations_hebergement.*, u1.idUtilisateur, u1.email, u1.mdp, u1.nom, u1.prenom, u1.idRole, u1.acceptRGPD, u1.dateAcceptRGPD, u1.DoB, u1.token, ru1.idRole, ru1.libelle, villes.description as descriptionVille FROM hebergement INNER JOIN villes USING(idVille) INNER JOIN reservations_hebergement USING(idHebergement) INNER JOIN utilisateurs u1 ON u1.idUtilisateur = reservations_hebergement.idUtilisateur INNER JOIN roles ru1 ON u1.idRole = ru1.idRole INNER JOIN utilisateurs u2 ON u2.idUtilisateur = hebergement.idUtilisateur INNER JOIN roles ru2 ON u2.idRole = ru2.idRole INNER JOIN regions USING(idRegion) INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage WHERE hebergement.idUtilisateur = @idUtilisateur AND is_building = 0 AND dateFin BETWEEN @date1 AND @date2";
            query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
            query.Parameters.AddWithValue("@date1", one);
            query.Parameters.AddWithValue("@date2", two);
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                string uuid = "";
                string descriptionVille = "";
                if (!reader.IsDBNull(reader.GetOrdinal("uuid"))) { uuid = reader.GetString(8); } else { uuid = ""; }
                if (!reader.IsDBNull(reader.GetOrdinal("descriptionVille"))) { descriptionVille = reader.GetString(8); } else { descriptionVille = ""; }

                Region Region = new Region(reader.GetInt32(20), reader.GetString(21), reader.GetFloat(22), reader.GetFloat(23), reader.GetInt32(24), reader.GetString(25));
                Ville Ville = new Ville(reader.GetInt32(12), reader.GetString(13), reader.GetString(14), reader.GetFloat(15), reader.GetFloat(16), descriptionVille, reader.GetString(19), Region);
                Role RoleProprietaire = new Role(reader.GetInt32(36), reader.GetString(37));
                Utilisateur ProprietaireHebergement = new Utilisateur(reader.GetInt32(26), reader.GetString(27), reader.GetString(28), reader.GetString(29), reader.GetString(30), reader.GetBoolean(32), reader.GetDateTime(33), reader.GetDateTime(34), RoleProprietaire);
                Hebergement Hebergement = new Hebergement(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDouble(5), reader.GetDouble(6), reader.GetDecimal(7), uuid, reader.GetDateTime(10), reader.GetBoolean(11), Ville, ProprietaireHebergement);
                Role RoleUtilisateurReservation = new Role(reader.GetInt32(57), reader.GetString(58));
                Utilisateur UtilisateurReservation = new Utilisateur(reader.GetInt32(47), reader.GetString(48), reader.GetString(49), reader.GetString(50), reader.GetString(51), reader.GetBoolean(53), reader.GetDateTime(54), reader.GetDateTime(55), RoleUtilisateurReservation);
                ReservationHebergement reservationHebergement = new ReservationHebergement(reader.GetInt32(38), reader.GetString(39), reader.GetDecimal(40), reader.GetDateTime(41), reader.GetDateTime(42), reader.GetInt32(43), reader.GetInt32(44), UtilisateurReservation, Hebergement);
                reservationHebergements.Add(reservationHebergement);
            }
            _bdd.Close();

            return reservationHebergements;
        }

        public string GetAge()
        {
            DateTime DoB = DateOfBirth;
            DateTime Now = DateTime.Now;

            return (Now.Subtract(DoB).Days / 365).ToString();
        }

        public bool UpdateMDP(string OldMotDePasse, string NewMotDePasse)
        {

            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT mdp FROM utilisateurs WHERE idUtilisateur = @idUtilisateur";
            query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
            MySqlDataReader reader = query.ExecuteReader();
            string mdp = "";
            while (reader.Read())
            {
                mdp = reader.GetString(0);
            }
            _bdd.Close();

            if (OldMotDePasse != null && BCrypt.Net.BCrypt.Verify(OldMotDePasse, mdp))
            {
                _bdd.Open();
                query = _bdd.CreateCommand();
                query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
                query.Parameters.AddWithValue("@mdp", BCrypt.Net.BCrypt.HashPassword(NewMotDePasse));
                query.CommandText = "UPDATE utilisateurs SET mdp = @mdp WHERE idUtilisateur = @idUtilisateur";

                if (query.ExecuteNonQuery() > 0)
                {
                    _bdd.Close();
                    return true;
                }
                else
                {
                    _bdd.Close();
                    return false;
                }
            } else
            {
                return false;
            }

        }

        public bool UpdateUser(string nom, string prenom, string email)
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
            query.Parameters.AddWithValue("@nom", nom);
            query.Parameters.AddWithValue("@prenom", prenom);
            query.Parameters.AddWithValue("@email", email);
            query.CommandText = "UPDATE utilisateurs SET nom = @nom, prenom = @prenom, email = @email WHERE idUtilisateur = @idUtilisateur";
            if (query.ExecuteNonQuery() > 0)
            {
                _bdd.Close();
                return true;
            }
            else
            {
                _bdd.Close();
                return false;
            }
        }

        public bool IsThisUserIsUnsubscribe()
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT desinscrit FROM utilisateurs WHERE idUtilisateur = @idUtilisateur";
            query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
            MySqlDataReader reader = query.ExecuteReader();
            bool desinscrit = false;
            while (reader.Read())
            {
                desinscrit  = reader.GetBoolean(0);
            }
            _bdd.Close();

            return desinscrit;
        }

        public bool Unsubscribe()
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
            query.Parameters.AddWithValue("@desinscrit", 1);
            query.CommandText = "UPDATE utilisateurs SET desinscrit = @desinscrit WHERE idUtilisateur = @idUtilisateur";
            if (query.ExecuteNonQuery() > 0)
            {
                _bdd.Close();
                return true;
            }
            else
            {
                _bdd.Close();
                return false;
            }
        }

    }
}
