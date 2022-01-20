using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AP.Model
{
    public class Region : Bdd
    {
        private int _idRegion { get; set; }
        public int IdRegion { get { return _idRegion; } set { _idRegion = value; } }

        private string _libelle { get; set; }
        public string Libelle { get { return _libelle; } set { _libelle = value; } }

        private float _latitude { get; set; }
        public float Latitude { get { return _latitude; } set { _latitude = value; } }

        private float _longitude { get; set; }
        public float Longitude { get { return _longitude; } set { _longitude = value; } }
        private int _lvZoom { get; set; }
        public int LvZoom { get { return _lvZoom; } set { _lvZoom = value; } }

        private string _description { get; set; }
        public string Description { get { return _description; } set { _description = value; } }

        public Region(int idRegion = 0)
        {
            if (idRegion != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM regions WHERE IdRegion = @IdRegion";
                query.Parameters.AddWithValue("@IdRegion", idRegion);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdRegion = reader.GetInt32(0);
                    this.Libelle = reader.GetString(1);
                    this.Latitude = reader.GetFloat(2);
                    this.Longitude = reader.GetFloat(3);
                    this.LvZoom = reader.GetInt32(4);
                    if (!reader.IsDBNull(reader.GetOrdinal("description"))) { this.Description = reader.GetString(5); } else { this.Description = ""; }
                }
                _bdd.Close();
            }
        }

        public void InitialiserRegion(int IdRegion, string libelle, float latitude, float longitude, int lvZoom, string description)
        {
            this.IdRegion = IdRegion;
            this.Libelle = libelle;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.LvZoom = lvZoom;
            this.Description = description;
        }

        public int GetIdRegionByNomRegion(string nomRegion)
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

        public List<Region> GetAllRegions()
        {
            List<Region> ListRegions = new List<Region>();
            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT * FROM regions";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                Region Region = new Region();
                Region.InitialiserRegion(reader.GetInt32(0), reader.GetString(1), reader.GetFloat(2), reader.GetFloat(3), reader.GetInt32(4), reader.GetString(5));
                ListRegions.Add(Region);
            }
            _bdd.Close();

            return ListRegions;
        }

    }
}

