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

        private List<Ville> _listVille;
        public List<Ville> ListVille { get { return _listVille; } set { _listVille = value; } }

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

                _bdd.Open();
                _listVille = new List<Ville>();
                query = _bdd.CreateCommand();
                query.Parameters.AddWithValue("@IdRegion", idRegion);
                query.CommandText = "SELECT idVille, villes.libelle, villes.code_postal, villes.latitude, villes.longitude, villes.idRegion, villes.description, villes.uuid, regions.libelle, regions.latitude, regions.longitude, regions.lv_zoom, regions.description as descriptionRegion FROM villes INNER JOIN regions USING(idRegion) WHERE idRegion = @IdRegion";
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    string description;
                    string uuid;
                    if (!reader.IsDBNull(reader.GetOrdinal("description"))) { description = reader.GetString(6); } else { description = ""; }
                    if (!reader.IsDBNull(reader.GetOrdinal("uuid"))) { uuid = reader.GetString(7); } else { uuid = ""; }
                    Region region = new Region(reader.GetInt32(5), reader.GetString(8), reader.GetFloat(9), reader.GetFloat(10), reader.GetInt32(11), reader.GetString(12));
                    Ville Ville = new Ville(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), description, uuid, region);
                    _listVille.Add(Ville);
                }
                _bdd.Close();
                
            }
        }

        public Region(int IdRegion, string libelle, float latitude, float longitude, int lvZoom, string description)
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

    }
}

