using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP.Model
{
    public class Ville : Bdd
    {
        private int _idVille { get; set; }
        public int IdVille { get { return _idVille; } set { _idVille = value;  }  }

        private string _libelle { get; set; }
        public string Libelle { get { return _libelle; } set { _libelle = value; } }

        private float _latitude { get; set; }
        public float Latitude { get { return _latitude; } set { _latitude = value; } }

        private float _longitude { get; set; }
        public float Longitude { get { return _longitude; } set { _longitude = value; } }

        private int _idRegion { get; set; }
        public int IdRegion { get { return _idRegion; } set { _idRegion = value; } }

        private string _description { get; set; }
        public string Description { get { return _description; } set { _description = value; } }

        private string _uuid { get; set; }
        public string Uuid { get { return _uuid; } set { _uuid = value; } }


        public Ville(int idVille = 0)
        {
            if(idVille != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM villes WHERE idVille = @idVille";
                query.Parameters.AddWithValue("@idVille", idVille);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdVille = reader.GetInt32(0);
                    this.Libelle = reader.GetString(1);
                    this.Latitude = reader.GetFloat(2);
                    this.Longitude = reader.GetFloat(3);
                    this.IdRegion = reader.GetInt32(4);
                    this.Description = reader.GetString(5);
                    this.Uuid = reader.GetString(6);
                }
                _bdd.Close();
            }
        }

        public void InitialiserVille(int idVille, string libelle, float latitude, float longitude, int idRegion, string description, string uuid)
        {
            this.IdVille = idVille;
            this.Libelle = libelle;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.IdRegion = idRegion;
            this.Description = description;
            this.Uuid = uuid;
        }

        public List<Ville> GetAllVille()
        {
            _bdd.Open();

            List<Ville> Villes = new List<Ville>();
            float latitude;
            float longitude;
            int idRegion;
            string description;
            string uuid;

            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT * FROM villes";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                Ville ville = new Ville();

                if (!reader.IsDBNull(reader.GetOrdinal("latitude"))) { latitude = reader.GetFloat(2); } else { latitude = 0; }
                if (!reader.IsDBNull(reader.GetOrdinal("longitude"))) { longitude = reader.GetFloat(3); } else { longitude = 0; }
                if (!reader.IsDBNull(reader.GetOrdinal("description"))) { idRegion = reader.GetInt32(4); } else { idRegion = 0; }
                if (!reader.IsDBNull(reader.GetOrdinal("description"))) { description = reader.GetString(5); } else { description = "null"; }
                if (!reader.IsDBNull(reader.GetOrdinal("uuid"))) { uuid = reader.GetString(6); } else { uuid = ""; }

                ville.InitialiserVille(reader.GetInt32(0), reader.GetString(1), latitude, longitude, idRegion, description, uuid);

                Villes.Add(ville);
            }

            _bdd.Close();

            return Villes;
        }

        public bool IsThisTownExist(string ville)
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query = _bdd.CreateCommand();
            query.Parameters.AddWithValue("@libelle", ville);
            query.CommandText = "SELECT COUNT(*) FROM villes WHERE libelle = @libelle";
            MySqlDataReader reader = query.ExecuteReader();
            int result = 0;
            while (reader.Read())
            {
                result = reader.GetInt32(0);
            }
            _bdd.Close();
            if (result > 0)
                return true;
            else
                return false;
        }

        public int GetIdRegion(string nomRegion)
        {
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT idRegion FROM regions WHERE libelle = @libelle";
            query.Parameters.AddWithValue("@libelle", nomRegion);
            MySqlDataReader reader = query.ExecuteReader();
            int idRegion = 0;
            while (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("idRegion"))) { idRegion = reader.GetInt32(0); } else { idRegion = 0; }
            }
            _bdd.Close();

            return idRegion;
        }
    }
}
