using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP.Forms;
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

        private int _idVille;
        public int IdVille { get { return _idVille; } set { _idVille = value; } }

        private double _latitude;
        public double Latitude { get { return _latitude; } set { _latitude = value; } }

        private double _longitude;
        public double Longitude { get { return _longitude; } set { _longitude = value; } }

        private decimal _prix;
        public decimal Prix { get { return _prix; } set { _prix = value; } }

        private string _uuid;
        public string Uuid { get { return _uuid; } set { _uuid = value; } }

        private int _idUtilisateur;
        public int IdUtilisateur { get { return _idUtilisateur; } set { _idUtilisateur = value; } }

        private DateTime _dateEnregistrement;
        public DateTime DateEnregistrement { get { return _dateEnregistrement; } set { _dateEnregistrement = value; } }

        private List<Avis> _listAvis = new List<Avis>();

        public List<Avis> ListAvis { get { return _listAvis; } set { _listAvis = value; } }

        private List<Option> _listOptions = new List<Option>();

        public List<Option> ListOption { get { return _listOptions; } set { _listOptions = value; } }

        public Hebergement(int IdHebergement = 0)
        {
            if (IdHebergement != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM hebergement WHERE idHebergement = @idHebergement";
                query.Parameters.AddWithValue("@idHebergement", IdHebergement);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdHebergement = reader.GetInt32(0);
                    this.Libelle = reader.GetString(1);
                    this.Adresse = reader.GetString(2);
                    this.Description = reader.GetString(3);
                    this.IdVille = reader.GetInt32(4);
                    this.Latitude = reader.GetDouble(5);
                    this.Longitude = reader.GetDouble(6);
                    this.Prix = reader.GetDecimal(7);
                    this.Uuid = reader.GetString(8);
                    this.IdUtilisateur = reader.GetInt32(9);
                    this.DateEnregistrement = reader.GetDateTime(10);
                }
                _bdd.Close();

                _bdd.Open();
                query.CommandText = "SELECT * FROM avis WHERE idHebergement = @idHebergement";
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Avis avis = new Avis();
                    avis.InitialisationAvis(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5));
                    _listAvis.Add(avis);
                }
                _bdd.Close();

                _bdd.Open();
                query.CommandText = "SELECT op.* FROM options op INNER JOIN options_by_hebergement USING(idOption) WHERE idHebergement = @idHebergement";
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    Option option = new Option();
                    option.InitialisationOption(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    ListOption.Add(option);
                }
                _bdd.Close();

            }
        }

        public void InitialisationHebergement(int id, string libelle, string adresse, string description, int idVille, double latitude, double longitude, decimal prix, string uuid, int idUtilisateur, DateTime dateEnregistrement)
        {
            this.IdHebergement = id;
            this.Libelle = libelle;
            this.Adresse = adresse;
            this.Description = description;
            this.IdVille = idVille;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Prix = prix;
            this.Uuid = uuid;
            this.IdUtilisateur = idUtilisateur;
            this.DateEnregistrement = dateEnregistrement;
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
            query.Parameters.AddWithValue("@idVille", IdVille);
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

        public void UpdateOption(int id, int option, List<string> name)
        {
            string req = "";

            _bdd.Open();
            MySqlCommand supOption = _bdd.CreateCommand();
            supOption.Parameters.AddWithValue("@idHebergement", id);
            supOption.CommandText = "delete from options_by_hebergement where idHebergement = @idHebergement";
            supOption.ExecuteNonQuery();
            _bdd.Close();

            if(name.Count > 0)
            {
                _bdd.Open();
                MySqlCommand ajoutOption = _bdd.CreateCommand();
                ajoutOption.Parameters.AddWithValue("@idHebergement", id);
                for (int i = 0; i < name.Count(); i++)
                {
                    ajoutOption.Parameters.AddWithValue("@idOption" + i, name[i]);
                    req += "(@idHebergement, @idOption" + i + "),";
                }
                req = req.TrimEnd(',');
                ajoutOption.CommandText = "insert into options_by_hebergement(idHebergement, idOption) values" + req;
                if (ajoutOption.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Modification effectuée !");
                }
                else
                {
                    MessageBox.Show("Un problème est apparu veuillez recommencer");
                }
                _bdd.Close();
            }
            else
            {
                MessageBox.Show("Modification effectuée !");
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
            DateTime threeMounth = new DateTime(now.Year, now.AddMonths(-3).Month, 1);
            DateTime sixMounth = new DateTime(now.Year, now.AddMonths(-6).Month, 1);
            DateTime oneYear = new DateTime(now.AddYears(-1).Year, now.Month, 1);

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
