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

        private int _idRole;
        public int IdRole { get { return _idRole; } set { _idRole = value; } }

        private bool _acceptRGPD;
        public bool AcceptRGPD { get { return _acceptRGPD; } set { _acceptRGPD = value; } }

        private DateTime _dateAcceptRGPD;
        public DateTime DateAcceptRGPD { get { return _dateAcceptRGPD; } set { _dateAcceptRGPD = value; } }

        private DateTime _dateOfBirth;
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

        private List<Hebergement> _listHebergements = new List<Hebergement>();

        public List<Hebergement> ListHebergements { get { return _listHebergements; } set { _listHebergements = value; } }

        public Utilisateur(int IdUtilisateur = 0)
        {
            if(IdUtilisateur != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
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
            while (reader.Read())
            {
                this.IdUtilisateur = reader.GetInt32(0);
                this.Email = reader.GetString(1);
                this.Mdp = reader.GetString(2);
                this.Nom = reader.GetString(3);
                this.Prenom = reader.GetString(4);
                this.IdRole = reader.GetInt32(5);
                this.AcceptRGPD = reader.GetBoolean(6);
                this.DateAcceptRGPD = reader.GetDateTime(7);
                this.DateOfBirth = reader.GetDateTime(8);
            }
            _bdd.Close();

            GetAllHebergements();
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
            _listHebergements.Clear();

            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT * FROM hebergement WHERE idUtilisateur = @idUtilisateur";
            query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                _listHebergements.Add(new Hebergement(reader.GetInt32(0)));
            }
            _bdd.Close();

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
            query.CommandText = "SELECT reservations_hebergement.* FROM hebergement INNER JOIN reservations_hebergement USING(idHebergement) INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage WHERE hebergement.idUtilisateur = @idUtilisateur AND is_building = 0 AND dateFin BETWEEN @date1 AND @date2";
            query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
            query.Parameters.AddWithValue("@date1", one.ToString("yyyy-MM-dd"));
            query.Parameters.AddWithValue("@date2", two.ToString("yyyy-MM-dd"));
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                ReservationHebergement reservationHebergement = new ReservationHebergement();
                reservationHebergement.InitialiserReservationHebergement(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8));
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


    }
}
