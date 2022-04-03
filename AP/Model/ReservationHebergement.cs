using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace AP.Model
{
    public class ReservationHebergement : Bdd
    {
        private int _idReservationHebergement { get; set; }
        public int IdReservationHebergement { get { return _idReservationHebergement; } set { _idReservationHebergement = value;  }  }

        private string _codeReservation { get; set; }
        public string CodeReservation { get { return _codeReservation; } set { _codeReservation = value; } }

        private decimal _prix { get; set; }
        public decimal Prix { get { return _prix; } set { _prix = value; } }

        private DateTime _dateDebut { get; set; }
        public DateTime DateDebut { get { return _dateDebut; } set { _dateDebut = value; } }

        private DateTime _dateFin { get; set; }
        public DateTime DateFin { get { return _dateFin; } set { _dateFin = value; } }

        private int _nbJours { get; set; }
        public int NbJours { get { return _nbJours; } set { _nbJours = value; } }

        private int _idVoyage { get; set; }
        public int IdVoyage { get { return _idVoyage; } set { _idVoyage = value; } }

        private Utilisateur _utilisateur { get; set; }
        public Utilisateur Utilisateur { get { return _utilisateur; } set { _utilisateur = value; } }

        private Hebergement _hebergement { get; set; }
        public Hebergement Hebergement { get { return _hebergement; } set { _hebergement = value; } }

        public ReservationHebergement(int idReservationHebergement = 0)
        {
            if(idReservationHebergement != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM reservations_hebergement WHERE idReservationHebergement = @idReservationHebergement";
                query.Parameters.AddWithValue("@idReservationHebergement", idReservationHebergement);
                MySqlDataReader reader = query.ExecuteReader();
                int idUtilisateur = 0;
                int idHebergement = 0;
                while (reader.Read())
                {
                    this.IdReservationHebergement = reader.GetInt32(0);
                    this.CodeReservation = reader.GetString(1);
                    this.Prix = reader.GetDecimal(2);
                    this.DateDebut = reader.GetDateTime(3);
                    this.DateFin = reader.GetDateTime(4);
                    this.NbJours = reader.GetInt32(5);
                    this.IdVoyage = reader.GetInt32(6);
                    idUtilisateur = reader.GetInt32(7);
                    idHebergement = reader.GetInt32(8);
                }
                _bdd.Close();

                _bdd.Open();
                this.Utilisateur = new Utilisateur();
                query.CommandText = "SELECT utilisateurs.idUtilisateur, utilisateurs.email, utilisateurs.mdp, utilisateurs.nom, utilisateurs.prenom, utilisateurs.idRole, utilisateurs.acceptRGPD, utilisateurs.dateAcceptRGPD, utilisateurs.DoB, utilisateurs.token, roles.idRole, roles.libelle FROM utilisateurs INNER JOIN roles USING(idRole) WHERE idUtilisateur = @idUtilisateur";
                query.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Role Role = new Role(reader.GetInt32(10), reader.GetString(11));
                    this.Utilisateur = new Utilisateur(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(6), reader.GetDateTime(7), reader.GetDateTime(8), Role);
                }
                _bdd.Close();

                _bdd.Open();
                this.Hebergement = new Hebergement();
                query.CommandText = "SELECT hebergement.idHebergement, hebergement.libelle, hebergement.adresse, hebergement.description, hebergement.idVille, hebergement.latitude, hebergement.longitude, hebergement.prix, hebergement.uuid, hebergement.idUtilisateur, hebergement.dateEnregistrement, hebergement.actif , villes.idVille, villes.libelle, villes.code_postal, villes.latitude, villes.longitude, villes.idRegion, villes.description, villes.uuid, regions.idRegion, regions.libelle, regions.latitude, regions.longitude, regions.lv_zoom, regions.description, utilisateurs.idUtilisateur, utilisateurs.email, utilisateurs.mdp, utilisateurs.nom, utilisateurs.prenom, utilisateurs.idRole, utilisateurs.acceptRGPD, utilisateurs.dateAcceptRGPD, utilisateurs.DoB, utilisateurs.token, villes.description as descriptionVille FROM hebergement INNER JOIN villes USING(idVille) INNER JOIN utilisateurs USING(idUtilisateur) INNER JOIN regions USING(idRegion) WHERE idHebergement = @idHebergement";
                query.Parameters.AddWithValue("@idHebergement", idHebergement);
                while (reader.Read())
                {
                    string uuid = "";
                    string descriptionVille = "";
                    if (!reader.IsDBNull(reader.GetOrdinal("uuid"))) { uuid = reader.GetString(8); } else { uuid = ""; }
                    if (!reader.IsDBNull(reader.GetOrdinal("descriptionVille"))) { descriptionVille = reader.GetString(18); } else { descriptionVille = ""; }

                    Region Region = new Region(reader.GetInt32(20), reader.GetString(21), reader.GetFloat(22), reader.GetFloat(23), reader.GetInt32(24), reader.GetString(25));
                    Ville Ville = new Ville(reader.GetInt32(12), reader.GetString(13), reader.GetString(14), reader.GetFloat(15), reader.GetFloat(16), descriptionVille, reader.GetString(19), Region);
                    Role Role = new Role(reader.GetInt32(36), reader.GetString(37));
                    Utilisateur Utilisateur = new Utilisateur(reader.GetInt32(26), reader.GetString(27), reader.GetString(28), reader.GetString(29), reader.GetString(30), reader.GetBoolean(32), reader.GetDateTime(33), reader.GetDateTime(34), Role);

                    this.Hebergement = new Hebergement(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDouble(5), reader.GetDouble(6), reader.GetDecimal(7), uuid, reader.GetDateTime(10), reader.GetBoolean(11), Ville, Utilisateur);
                }
                _bdd.Close();

            }
        }

        public ReservationHebergement(int idReservationHebergement, string codeReservation, decimal prix, DateTime dateDebut, DateTime dateFin, int nbJours, int idVoyage, Utilisateur utilisateur, Hebergement hebergement)
        {
            this.IdReservationHebergement = idReservationHebergement;
            this.CodeReservation = codeReservation;
            this.Prix = prix;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
            this.NbJours = nbJours;
            this.IdVoyage = idVoyage;
            this.Utilisateur = utilisateur;
            this.Hebergement = hebergement;
        }

        public Ville GetVilleInfos()
        {
            Ville Ville = new Ville();

            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT villes.idVille, villes.libelle, villes.code_postal, villes.latitude, villes.longitude, villes.idRegion, villes.description, villes.uuid, regions.idRegion, regions.libelle, regions.latitude, regions.longitude, regions.lv_zoom, regions.description FROM hebergement INNER JOIN villes USING(idVille) INNER JOIN regions USING(idRegion) WHERE idHebergement = @idHebergement";
            query.Parameters.AddWithValue("@idHebergement", this.Hebergement.IdHebergement);
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                string description;
                string uuid;
                if (!reader.IsDBNull(reader.GetOrdinal("description"))) { description = reader.GetString(6); } else { description = ""; }
                if (!reader.IsDBNull(reader.GetOrdinal("uuid"))) { uuid = reader.GetString(7); } else { uuid = ""; }
                Region region = new Region(reader.GetInt32(8), reader.GetString(9), reader.GetFloat(10), reader.GetFloat(11), reader.GetInt32(12), reader.GetString(13));
                Ville = new Ville(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), description, uuid, region);
            }
            _bdd.Close();

            return Ville;
        }
        public List<ReservationHebergement> GetReservationAVenir(int idHebergement)
        {
            List<ReservationHebergement> reservationHebergements = new List<ReservationHebergement>();

            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT hebergement.idHebergement, hebergement.libelle, hebergement.adresse, hebergement.description, hebergement.idVille, hebergement.latitude, hebergement.longitude, hebergement.prix, hebergement.uuid, hebergement.idUtilisateur, hebergement.dateEnregistrement, hebergement.actif , villes.idVille, villes.libelle, villes.code_postal, villes.latitude, villes.longitude, villes.idRegion, villes.description, villes.uuid, regions.idRegion, regions.libelle, regions.latitude, regions.longitude, regions.lv_zoom, regions.description, u2.idUtilisateur, u2.email, u2.mdp, u2.nom, u2.prenom, u2.idRole, u2.acceptRGPD, u2.dateAcceptRGPD, u2.DoB, u2.token, ru2.idRole, ru2.libelle, reservations_hebergement.*, u1.idUtilisateur, u1.email, u1.mdp, u1.nom, u1.prenom, u1.idRole, u1.acceptRGPD, u1.dateAcceptRGPD, u1.DoB, u1.token, ru1.idRole, ru1.libelle, villes.description as descriptionVille FROM hebergement INNER JOIN villes USING(idVille) INNER JOIN reservations_hebergement USING(idHebergement) INNER JOIN utilisateurs u1 ON u1.idUtilisateur = reservations_hebergement.idUtilisateur INNER JOIN roles ru1 ON u1.idRole = ru1.idRole INNER JOIN utilisateurs u2 ON u2.idUtilisateur = hebergement.idUtilisateur INNER JOIN roles ru2 ON u2.idRole = ru2.idRole INNER JOIN regions USING(idRegion) INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage WHERE idHebergement = @idHebergement AND dateDebut > NOW() ORDER BY dateDebut";
            query.Parameters.AddWithValue("@idHebergement", idHebergement);
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                string uuid = "";
                string descriptionVille = "";
                if (!reader.IsDBNull(reader.GetOrdinal("uuid"))) { uuid = reader.GetString(8); } else { uuid = ""; }
                if (!reader.IsDBNull(reader.GetOrdinal("descriptionVille"))) { descriptionVille = reader.GetString(18); } else { descriptionVille = ""; }

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

        public ReservationHebergement GetReservationEnCours(int idHebergement)
        {
            ReservationHebergement reservationHebergement = new ReservationHebergement();

            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT hebergement.idHebergement, hebergement.libelle, hebergement.adresse, hebergement.description, hebergement.idVille, hebergement.latitude, hebergement.longitude, hebergement.prix, hebergement.uuid, hebergement.idUtilisateur, hebergement.dateEnregistrement, hebergement.actif , villes.idVille, villes.libelle, villes.code_postal, villes.latitude, villes.longitude, villes.idRegion, villes.description, villes.uuid, regions.idRegion, regions.libelle, regions.latitude, regions.longitude, regions.lv_zoom, regions.description, u2.idUtilisateur, u2.email, u2.mdp, u2.nom, u2.prenom, u2.idRole, u2.acceptRGPD, u2.dateAcceptRGPD, u2.DoB, u2.token, ru2.idRole, ru2.libelle, reservations_hebergement.*, u1.idUtilisateur, u1.email, u1.mdp, u1.nom, u1.prenom, u1.idRole, u1.acceptRGPD, u1.dateAcceptRGPD, u1.DoB, u1.token, ru1.idRole, ru1.libelle, villes.description as descriptionVille FROM hebergement INNER JOIN villes USING(idVille) INNER JOIN reservations_hebergement USING(idHebergement) INNER JOIN utilisateurs u1 ON u1.idUtilisateur = reservations_hebergement.idUtilisateur INNER JOIN roles ru1 ON u1.idRole = ru1.idRole INNER JOIN utilisateurs u2 ON u2.idUtilisateur = hebergement.idUtilisateur INNER JOIN roles ru2 ON u2.idRole = ru2.idRole INNER JOIN regions USING(idRegion) INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage WHERE idHebergement = @idHebergement AND dateDebut < NOW() AND dateFin > NOW()";
            query.Parameters.AddWithValue("@idHebergement", idHebergement);
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                string uuid = "";
                if (!reader.IsDBNull(reader.GetOrdinal("uuid"))) { uuid = reader.GetString(8); } else { uuid = ""; }
                string descriptionVille = "";
                if (!reader.IsDBNull(reader.GetOrdinal("descriptionVille"))) { descriptionVille = reader.GetString(18); } else { descriptionVille = ""; }

                Region Region = new Region(reader.GetInt32(20), reader.GetString(21), reader.GetFloat(22), reader.GetFloat(23), reader.GetInt32(24), reader.GetString(25));
                Ville Ville = new Ville(reader.GetInt32(12), reader.GetString(13), reader.GetString(14), reader.GetFloat(15), reader.GetFloat(16), descriptionVille, reader.GetString(19), Region);
                Role RoleProprietaire = new Role(reader.GetInt32(36), reader.GetString(37));
                Utilisateur ProprietaireHebergement = new Utilisateur(reader.GetInt32(26), reader.GetString(27), reader.GetString(28), reader.GetString(29), reader.GetString(30), reader.GetBoolean(32), reader.GetDateTime(33), reader.GetDateTime(34), RoleProprietaire);
                Hebergement Hebergement = new Hebergement(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDouble(5), reader.GetDouble(6), reader.GetDecimal(7), uuid, reader.GetDateTime(10), reader.GetBoolean(11), Ville, ProprietaireHebergement);
                Role RoleUtilisateurReservation = new Role(reader.GetInt32(57), reader.GetString(58));
                Utilisateur UtilisateurReservation = new Utilisateur(reader.GetInt32(47), reader.GetString(48), reader.GetString(49), reader.GetString(50), reader.GetString(51), reader.GetBoolean(53), reader.GetDateTime(54), reader.GetDateTime(55), RoleUtilisateurReservation);
                reservationHebergement = new ReservationHebergement(reader.GetInt32(38), reader.GetString(39), reader.GetDecimal(40), reader.GetDateTime(41), reader.GetDateTime(42), reader.GetInt32(43), reader.GetInt32(44), UtilisateurReservation, Hebergement);

            }
            _bdd.Close();

            return reservationHebergement;
        }

    }
}
