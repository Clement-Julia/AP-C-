using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                query.CommandText = "SELECT * FROM hebergements WHERE idHebergement = @idHebergement";
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

    }
}
