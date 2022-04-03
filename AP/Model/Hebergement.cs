using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AP.Model
{
    public class Hebergement : Bdd
    {

        private int _idHebergement;
        public int IdHebergement { get { return _idHebergement; } set { _idHebergement = value; } }

        private string _libelle;
        public string Libelle { get { return _libelle; } set { _libelle = value; } }

        private string _adresse;
        public string Adresse { get { return _adresse; } set { _adresse = value; } }

        private string _description;
        public string Description { get { return _description; } set { _description = value; } }

        private double _latitude;
        public double Latitude { get { return _latitude; } set { _latitude = value; } }

        private double _longitude;
        public double Longitude { get { return _longitude; } set { _longitude = value; } }

        private decimal _prix;
        public decimal Prix { get { return _prix; } set { _prix = value; } }

        private string _uuid;
        public string Uuid { get { return _uuid; } set { _uuid = value; } }

        private DateTime _dateEnregistrement;
        public DateTime DateEnregistrement { get { return _dateEnregistrement; } set { _dateEnregistrement = value; } }

        private Boolean _actif;
        public Boolean Actif { get { return _actif; } set { _actif = value; } }

        private Utilisateur _utilisateur;
        public Utilisateur Utilisateur { get { return _utilisateur; } set { _utilisateur = value; } }

        private Ville _ville;
        public Ville Ville { get { return _ville; } set { _ville = value; } }

        private List<Avis> _listAvis = new List<Avis>();
        public List<Avis> ListAvis { get { return _listAvis; } set { _listAvis = value; } }

        private List<Option> _listOptions = new List<Option>();
        public List<Option> ListOption { get { return _listOptions; } set { _listOptions = value; } }

        public Hebergement(int IdHebergement = 0)
        {
            if (IdHebergement != 0)
            {
                // On initialise l'objet hebergement avec les deux objets utilisateurs et ville (qui eux mêmes contiennent region / role)
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT hebergement.idHebergement, hebergement.libelle, hebergement.adresse, hebergement.description, hebergement.idVille, hebergement.latitude, hebergement.longitude, hebergement.prix, hebergement.uuid, hebergement.idUtilisateur, hebergement.dateEnregistrement, hebergement.actif , villes.idVille, villes.libelle, villes.code_postal, villes.latitude, villes.longitude, villes.idRegion, villes.description, villes.uuid, regions.idRegion, regions.libelle, regions.latitude, regions.longitude, regions.lv_zoom, regions.description, utilisateurs.idUtilisateur, utilisateurs.email, utilisateurs.mdp, utilisateurs.nom, utilisateurs.prenom, utilisateurs.idRole, utilisateurs.acceptRGPD, utilisateurs.dateAcceptRGPD, utilisateurs.DoB, utilisateurs.token, roles.idRole, roles.libelle, villes.description as descriptionVille FROM hebergement INNER JOIN villes USING(idVille) INNER JOIN utilisateurs USING(idUtilisateur) INNER JOIN roles USING(idRole) INNER JOIN regions USING(idRegion) WHERE idHebergement = @idHebergement";
                query.Parameters.AddWithValue("@idHebergement", IdHebergement);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    string descriptionVille = "";
                    if (!reader.IsDBNull(reader.GetOrdinal("descriptionVille"))) { descriptionVille = reader.GetString(18); } else { descriptionVille = ""; }

                    Region Region = new Region(reader.GetInt32(20), reader.GetString(21), reader.GetFloat(22), reader.GetFloat(23), reader.GetInt32(24), reader.GetString(25));
                    Ville Ville = new Ville(reader.GetInt32(12), reader.GetString(13), reader.GetString(14), reader.GetFloat(15), reader.GetFloat(16), descriptionVille, reader.GetString(19), Region);
                    Role Role = new Role(reader.GetInt32(36), reader.GetString(37));
                    Utilisateur Utilisateur = new Utilisateur(reader.GetInt32(26), reader.GetString(27), reader.GetString(28), reader.GetString(29), reader.GetString(30), reader.GetBoolean(32), reader.GetDateTime(33), reader.GetDateTime(34), Role);

                    this.IdHebergement = reader.GetInt32(0);
                    this.Libelle = reader.GetString(1);
                    this.Adresse = reader.GetString(2);
                    this.Description = reader.GetString(3);
                    this.Ville = Ville;
                    this.Latitude = reader.GetDouble(5);
                    this.Longitude = reader.GetDouble(6);
                    this.Prix = reader.GetDecimal(7);
                    if (!reader.IsDBNull(reader.GetOrdinal("uuid"))) { this.Uuid = reader.GetString(8); } else { this.Uuid = ""; }
                    this.Utilisateur = Utilisateur;
                    this.DateEnregistrement = reader.GetDateTime(10);
                    this.Actif = reader.GetBoolean(11);
                }
                _bdd.Close();

                // On initialise les avis
                _bdd.Open();
                query.CommandText = "SELECT utilisateurs.idUtilisateur, utilisateurs.email, utilisateurs.mdp, utilisateurs.nom, utilisateurs.prenom, utilisateurs.idRole, utilisateurs.acceptRGPD, utilisateurs.dateAcceptRGPD, utilisateurs.DoB, utilisateurs.token, roles.idRole, roles.libelle, avis.idAvis, avis.date, avis.note, avis.commentaire, avis.idUtilisateur, avis.idHebergement FROM avis INNER JOIN utilisateurs USING(idUtilisateur) INNER JOIN roles USING(idRole) WHERE idHebergement = @idHebergement";
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Role Role = new Role(reader.GetInt32(10), reader.GetString(11));
                    Utilisateur Utilisateur = new Utilisateur(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(6), reader.GetDateTime(7), reader.GetDateTime(8), Role);
                    // Hebergement ne sera pas instancier car on veut éviter un inception (un hebergement qui contient une liste d'avis et chaque avis est relié à un hébergement qui lui même possède une liste d'avis ... etc)
                    Hebergement Hebergement = new Hebergement();
                    Avis avis = new Avis(reader.GetInt32(12), reader.GetDateTime(13), reader.GetInt32(14), reader.GetString(15), Utilisateur, Hebergement);
                    _listAvis.Add(avis);
                }
                _bdd.Close();

                // On initialise les options
                _bdd.Open();
                query.CommandText = "SELECT op.* FROM options op INNER JOIN options_by_hebergement USING(idOption) WHERE idHebergement = @idHebergement";
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Option option = new Option(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    ListOption.Add(option);
                }
                _bdd.Close();

            }
        }

        public Hebergement(int id, string libelle, string adresse, string description, double latitude, double longitude, decimal prix, string uuid, DateTime dateEnregistrement, Boolean actif, Ville ville, Utilisateur utilisateur)
        {
            this.IdHebergement = id;
            this.Libelle = libelle;
            this.Adresse = adresse;
            this.Description = description;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Prix = prix;
            this.Uuid = uuid;
            this.DateEnregistrement = dateEnregistrement;
            this.Actif = actif;
            this.Ville = ville;
            this.Utilisateur = utilisateur;
        }

        public Boolean AddHebergement(string libelle, string description, string nomVille, string codePostal, string adresse, float latitude, float longitude, decimal prix, int idUtilisateur, int idRegion, double latitudeVille = 0, double longitudeVille = 0)
        {
            Boolean error = false;

            try
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();

                query.Parameters.AddWithValue("@nomVille", nomVille);
                query.Parameters.AddWithValue("@code_postal", codePostal);
                query.Parameters.AddWithValue("@idRegion", idRegion);
                query.Parameters.AddWithValue("@latitudeVille", latitudeVille);
                query.Parameters.AddWithValue("@longitudeVille", longitudeVille);

                if (latitudeVille != 0 && longitudeVille != 0)
                {
                    query.CommandText = "INSERT INTO villes (libelle, code_postal, latitude, longitude, idRegion) VALUES (@nomVille, @code_postal, @latitudeVille, @longitudeVille, @idRegion)";
                    query.ExecuteNonQuery();
                    _bdd.Close();
                    _bdd.Open();
                }

                query.CommandText = "SELECT idVille FROM villes WHERE libelle = @nomVille AND idRegion = @idRegion";
                MySqlDataReader reader = query.ExecuteReader();
                int idVille = 0;
                while (reader.Read())
                {
                    idVille = reader.GetInt32(0);
                }
                _bdd.Close();

                _bdd.Open();
                query.CommandText = "INSERT INTO hebergement (libelle, adresse, description, idVille, latitude, longitude, prix, idUtilisateur, dateEnregistrement, actif) VALUES(@libelle, @adresse, @description, @idVille, @latitude, @longitude, @prix, @idUtilisateur, NOW(), 0)";
                query.Parameters.AddWithValue("@libelle", libelle);
                query.Parameters.AddWithValue("@adresse", adresse);
                query.Parameters.AddWithValue("@description", description);
                query.Parameters.AddWithValue("@idVille", idVille);
                query.Parameters.AddWithValue("@latitude", latitude);
                query.Parameters.AddWithValue("@longitude", longitude);
                query.Parameters.AddWithValue("@prix", prix);
                query.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                query.ExecuteNonQuery();

                _bdd.Close();
            }
            catch (Exception e)
            {
                // LEVEE D'UNE EXCEPTION
                error = true;
            }

            if (error)
                return false;
            else
                return true;

        }

        public bool UpdateHebergement()
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "UPDATE hebergement SET idHebergement = @idHebergement, libelle = @libelle, adresse = @adresse, description = @description, idVille = @idVille, latitude = @latitude, longitude = @longitude, prix = @prix WHERE idHebergement = @idHebergement";
            query.Parameters.AddWithValue("@idHebergement", IdHebergement);
            query.Parameters.AddWithValue("@libelle", Libelle);
            query.Parameters.AddWithValue("@adresse", Adresse);
            query.Parameters.AddWithValue("@description", Description);
            query.Parameters.AddWithValue("@idVille", Ville.IdVille);
            query.Parameters.AddWithValue("@latitude", Latitude);
            query.Parameters.AddWithValue("@longitude", Longitude);
            query.Parameters.AddWithValue("@prix", Prix);
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
        
        public bool DeleteHebergement()
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "DELETE FROM hebergement where idHebergement = @idHebergement";
            query.Parameters.AddWithValue("@idHebergement", IdHebergement);
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

        public int GetStatusHebergement(int idHebergement)
        {
            _bdd.Open();

            MySqlCommand query = new MySqlCommand("est_reserver", _bdd);
            query.CommandType = CommandType.StoredProcedure;

            query.Parameters.AddWithValue("p_idHebergement", idHebergement);
            query.Parameters["p_idHebergement"].Direction = ParameterDirection.Input;

            query.Parameters.AddWithValue("nbr", 0);
            query.Parameters["nbr"].Direction = ParameterDirection.Output;

            query.ExecuteNonQuery();

            _bdd.Close();
            return Convert.ToInt32(query.Parameters["nbr"].Value);

        }

        public string GetNombreReservationEnCours()
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT * FROM reservations_hebergement INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage WHERE idHebergement = @idHebergement AND is_building = 0 AND now() BETWEEN dateDebut AND dateFIn";
            query.Parameters.AddWithValue("@idHebergement", IdHebergement);
            MySqlDataReader reader = query.ExecuteReader();
            int quantite = 0;
            while (reader.Read()){ quantite = reader.GetInt32(0); }

            if (quantite > 0)
            {
                _bdd.Close();
                return "1 réservation";
            }
            else
            {
                _bdd.Close();
                return "Pas de réservation";
            }
        }

        public string GetNombreReservationAVenir()
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT Count(idHebergement) FROM reservations_hebergement INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage WHERE idHebergement = @idHebergement AND is_building = 0 AND now() < dateDebut";
            query.Parameters.AddWithValue("@idHebergement", IdHebergement);
            MySqlDataReader reader = query.ExecuteReader();
            int quantite = 0;
            while (reader.Read()) { quantite = reader.GetInt32(0); }

            if (quantite == 0)
            {
                _bdd.Close();
                return "Pas de réservation";
            }
            else if (quantite > 1)
            {
                _bdd.Close();
                return quantite + " réservations";
            }
            else
            {
                _bdd.Close();
                return "1 réservation";
            }
        }
        
        public int[] GetInfosAboutTOYear()
        {
            int year = DateTime.Now.Year;
            DateTime firstDay = new DateTime(year, 1, 1);
            int tauxOccupation = 0;
            int nuitees = 0;
            int nbReservations = 0;
            DateTime minDate = DateTime.Now;

            _bdd.Open();

            MySqlCommand query = new MySqlCommand("get_infos_about_to_year", _bdd);
            query.CommandType = CommandType.StoredProcedure;

            query.Parameters.AddWithValue("p_id_hebergement", this._idHebergement);
            query.Parameters["p_id_hebergement"].Direction = ParameterDirection.Input;
            
            query.Parameters.AddWithValue("p_date", firstDay);
            query.Parameters["p_date"].Direction = ParameterDirection.Input;

            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("nuitees"))) { nuitees = reader.GetInt32(0); } else { nuitees = 0; }
                minDate = reader.GetDateTime(1);
                if (!reader.IsDBNull(reader.GetOrdinal("nbReservation"))) { nbReservations = reader.GetInt32(2); } else { nbReservations = 0; }
            }
            _bdd.Close();

            int nbTotalJours = 0;
            if (minDate < firstDay)
                nbTotalJours = DateTime.Now.Subtract(firstDay).Days;
            else
                nbTotalJours = DateTime.Now.Subtract(minDate).Days;

            tauxOccupation = (nuitees * 100) / nbTotalJours;
            int[] resultat = new int[4] { nbTotalJours, nuitees, tauxOccupation, nbReservations };

            return resultat;
        }
        
        public int[] GetInfosAboutTOAll()
        {
            int year = DateTime.Now.Year;
            DateTime firstDay = new DateTime(year, 1, 1);
            int tauxOccupation = 0;
            int nuitees = 0;
            int nbReservations = 0;
            DateTime dateEnregistrementHebergement = DateTime.Now;

            _bdd.Open();
            MySqlCommand query = new MySqlCommand("get_infos_about_to_all", _bdd);
            query.CommandType = CommandType.StoredProcedure;

            query.Parameters.AddWithValue("p_id_hebergement", this._idHebergement);
            query.Parameters["p_id_hebergement"].Direction = ParameterDirection.Input;

            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("nuitees"))) { nuitees = reader.GetInt32(0); } else { nuitees = 0; }
                dateEnregistrementHebergement = reader.GetDateTime(1);
                if (!reader.IsDBNull(reader.GetOrdinal("nbReservation"))) { nbReservations = reader.GetInt32(2); } else { nbReservations = 0; }
            }
            _bdd.Close();

            int nbTotalJours = DateTime.Now.Subtract(dateEnregistrementHebergement).Days;
            tauxOccupation = (nuitees * 100) / nbTotalJours;
            int[] resultat = new int[4] { nbTotalJours, nuitees, tauxOccupation, nbReservations };

            return resultat;
        }

        public int[] GetInfosGains()
        {

            DateTime now = DateTime.Now;
            DateTime thisMounth = new DateTime(now.Year, now.Month, 1);
            DateTime threeMounth = DateTime.Today.AddMonths(-3);
            DateTime sixMounth = DateTime.Today.AddMonths(-6);
            DateTime oneYear = DateTime.Today.AddMonths(-12);

            int gainDuMois = 0;
            int gainDuTrimestre = 0;
            int gainDuSemestre = 0;
            int gainAnnee = 0;
            int gainAll = 0;

            _bdd.Open();
            // Oui oui, c'est une procédure stockée :)
            MySqlCommand query = new MySqlCommand("obtenir_infos_gains", _bdd);
            query.CommandType = CommandType.StoredProcedure;

            query.Parameters.AddWithValue("p_id_hebergement", this._idHebergement);
            query.Parameters["p_id_hebergement"].Direction = ParameterDirection.Input;
            query.Parameters.AddWithValue("p_1_mois", thisMounth);
            query.Parameters["p_1_mois"].Direction = ParameterDirection.Input;
            query.Parameters.AddWithValue("p_3_mois", threeMounth);
            query.Parameters["p_3_mois"].Direction = ParameterDirection.Input;
            query.Parameters.AddWithValue("p_6_mois", sixMounth);
            query.Parameters["p_6_mois"].Direction = ParameterDirection.Input;
            query.Parameters.AddWithValue("p_1_an", oneYear);
            query.Parameters["p_1_an"].Direction = ParameterDirection.Input;

            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("gainsDuMois"))) { gainDuMois = reader.GetInt32(0); } else { gainDuMois = 0; }
                if (!reader.IsDBNull(reader.GetOrdinal("gainsDuTrimestre"))) { gainDuTrimestre = reader.GetInt32(1); } else { gainDuTrimestre = 0; }
                if (!reader.IsDBNull(reader.GetOrdinal("gainsDuSemestre"))) { gainDuSemestre = reader.GetInt32(2); } else { gainDuSemestre = 0; }
                if (!reader.IsDBNull(reader.GetOrdinal("gainsAnnee"))) { gainAnnee = reader.GetInt32(3); } else { gainAnnee = 0; }
                if (!reader.IsDBNull(reader.GetOrdinal("gainsALL"))) { gainAll = reader.GetInt32(4); } else { gainAll = 0; }
            }
            _bdd.Close();

            int[] resultat = new int[5] { gainDuMois, gainDuTrimestre, gainDuSemestre, gainAnnee, gainAll };
            return resultat;

        }

    }
}
