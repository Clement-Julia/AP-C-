using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP.Forms;

namespace AP.Model
{
    public class Hebergement : Bdd
    {

        private int _idHebergement;
        public int IdHebergement { get { return _idHebergement; } set { _idHebergement = value; } }

        private string _libelle;
        public string Libelle { get { return _libelle; } set { _libelle = value; } }

        private string _description;
        public string Description { get { return _description; } set { _description = value; } }

        private int _idVille;
        public int IdVille { get { return _idVille; } set { _idVille = value; } }

        private int _latitude;
        public int Latitude { get { return _latitude; } set { _latitude = value; } }

        private int _longitude;
        public int Longitude { get { return _longitude; } set { _longitude = value; } }

        private int _prix;
        public int Prix { get { return _prix; } set { _prix = value; } }

        private string _uuid;
        public string Uuid { get { return _uuid; } set { _uuid = value; } }

        private int _idUtilisateur;
        public int IdUtilisateur { get { return _idUtilisateur; } set { _idUtilisateur = value; } }

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
                    this.Description = reader.GetString(2);
                    this.IdVille = reader.GetInt32(3);
                    this.Latitude = reader.GetInt32(4);
                    this.Longitude = reader.GetInt32(5);
                    this.Prix = reader.GetInt32(6);
                    this.Uuid = reader.GetString(7);
                    this.IdUtilisateur = reader.GetInt32(8);
                }
                _bdd.Close();
            }
        }

        public void InitialisationHebergement(int id, string libelle, string description, int idVille, int latitude, int longitude, int prix, string uuid, int idUtilisateur)
        {
            this.IdHebergement = id;
            this.Libelle = libelle;
            this.Description = description;
            this.IdVille = idVille;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Prix = prix;
            this.Uuid = uuid;
            this.IdUtilisateur = idUtilisateur;
        }

        public bool UpdateHebergement()
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "UPDATE hebergements SET idHebergement = @idHebergement, libelle = @libelle, description = @description, idVille = @idVille, latitude = @latitude, longitude = @longitude, prix = @prix, uudi = @uuid, idUtilisateur = @idUtilisateur WHERE idHebergement = @idHebergement";
            query.Parameters.AddWithValue("@idHebergement", IdHebergement);
            query.Parameters.AddWithValue("@libelle", Libelle);
            query.Parameters.AddWithValue("@description", Description);
            query.Parameters.AddWithValue("@idVille", IdVille);
            query.Parameters.AddWithValue("@latitude", Latitude);
            query.Parameters.AddWithValue("@longitude", Longitude);
            query.Parameters.AddWithValue("@prix", Prix);
            query.Parameters.AddWithValue("@uuid", Uuid);
            query.Parameters.AddWithValue("@idUtilisateur", IdUtilisateur);
            _bdd.Close();
            if (query.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

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

        public List<Option> GetAllOptionsByHebergement(int id)
        {
            _bdd.Open();
            List<Option> Options = new List<Option>();
            MySqlCommand query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@idHebergement", id);
            query.CommandText = "SELECT * FROM options_by_hebergement where idHebergement = @idHebergement";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                Options.Add(new Option(reader.GetInt32(1)));
            }
            _bdd.Close();
            return Options;
        }

        public void UpdateOption(int id, int option, List<string> name)
        {
            string req = "";

            _bdd.Open();
            MySqlCommand supOption = _bdd.CreateCommand();
            supOption.Parameters.AddWithValue("@idHebergement", id);
            supOption.CommandText = "delete from options_by_hebergement where idHebergement = @idHebergement";
            supOption.ExecuteNonQuery();
            if (supOption.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Suppression effectuée !");
            }

            _bdd.Close();
            if(name.Count != 0)
            {
                _bdd.Open();
                MySqlCommand ajoutOption = _bdd.CreateCommand();
                ajoutOption.Parameters.AddWithValue("@idHebergement", id);
                for (int i = 0; i < name.Count(); i++)
                {
                    ajoutOption.Parameters.AddWithValue("@idOption" + i, name[i]);
                    req += "(@idHebergement, @idOption" + i + "),";
                }
                //req.Substring(0, req.Length - 1);
                req = req.TrimEnd(',');
                ajoutOption.CommandText = "insert into options_by_hebergement(idHebergement, idOption) values" + req;
                MessageBox.Show(ajoutOption.CommandText);
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
            MySqlCommand query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@idHebergement", this._idHebergement);
            query.Parameters.AddWithValue("@date", firstDay);
            query.CommandText = "SELECT SUM(nbJours), hebergement.dateEnregistrement, COUNT(*) FROM reservations_hebergement " +
                "INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage " +
                "INNER JOIN hebergement USING(idHebergement) " +
                "where idHebergement = @idHebergement  " +
                "AND is_building = 0 " +
                "AND dateFin BETWEEN " +
                "(CASE " +
                "WHEN (SELECT dateEnregistrement FROM hebergement WHERE idHebergement = @idHebergement) < @date THEN @date " +
                "ELSE (SELECT dateEnregistrement FROM hebergement WHERE idHebergement = @idHebergement) " +
                "END)" +
                "AND NOW()";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                nuitees = reader.GetInt32(0);
                minDate = reader.GetDateTime(1);
                nbReservations = reader.GetInt32(2);
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
            MySqlCommand query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@idHebergement", this._idHebergement);
            query.CommandText = "SELECT SUM(nbJours) as sum, hebergement.dateEnregistrement, COUNT(*) FROM reservations_hebergement " +
                "INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage " +
                "INNER JOIN hebergement USING(idHebergement) " +
                "where idHebergement = @idHebergement  " +
                "AND is_building = 0 " +
                "AND dateFin BETWEEN (SELECT dateEnregistrement FROM hebergement WHERE idHebergement = @idHebergement) AND NOW()";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                nuitees = reader.GetInt32(0);
                dateEnregistrementHebergement = reader.GetDateTime(1);
                nbReservations = reader.GetInt32(2);
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
            MySqlCommand query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@idHebergement", this._idHebergement);
            query.Parameters.AddWithValue("@thisMounth", thisMounth);
            query.Parameters.AddWithValue("@threeMounth", threeMounth);
            query.Parameters.AddWithValue("@sixMounth", sixMounth);
            query.Parameters.AddWithValue("@oneYear", oneYear);
            query.CommandText = "SELECT " +
                    "( SELECT SUM(reservations_hebergement.prix) FROM reservations_hebergement " +
                    "INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage  " +
                    "WHERE reservations_hebergement.idHebergement = hebergement.idHebergement " +
                    "AND is_building = 0 " +
                    "AND dateDebut > @thisMounth " +
                    "AND dateFin < NOW() ) as gainsDuMois, " +
                    "( SELECT SUM(reservations_hebergement.prix) FROM reservations_hebergement " +
                    "INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage  " +
                    "WHERE reservations_hebergement.idHebergement = hebergement.idHebergement " +
                    "AND is_building = 0 " +
                    "AND dateDebut > @threeMounth " +
                    "AND dateFin < NOW() ) as gainsDuTrimestre, " +
                    "( SELECT SUM(reservations_hebergement.prix) FROM reservations_hebergement " +
                    "INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage  " +
                    "WHERE reservations_hebergement.idHebergement = hebergement.idHebergement " +
                    "AND is_building = 0 " +
                    "AND dateDebut > @sixMounth " +
                    "AND dateFin < NOW() ) as gainsDuSemestre, " +
                    "( SELECT SUM(reservations_hebergement.prix) FROM reservations_hebergement " +
                    "INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage  " +
                    "WHERE reservations_hebergement.idHebergement = hebergement.idHebergement " +
                    "AND is_building = 0 " +
                    "AND dateDebut > @oneYear " +
                    "AND dateFin < NOW() ) as gainsAnnee, " +
                    "( SELECT SUM(reservations_hebergement.prix) FROM reservations_hebergement " +
                    "INNER JOIN reservations_voyages ON reservations_hebergement.idVoyage = reservations_voyages.idReservationVoyage  " +
                    "WHERE reservations_hebergement.idHebergement = hebergement.idHebergement " +
                    "AND is_building = 0 " +
                    "AND dateFin < NOW() ) as gainsALL " +
                "FROM hebergement WHERE idHebergement = @idHebergement";
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
