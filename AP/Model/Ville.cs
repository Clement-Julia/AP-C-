using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AP.Model
{
    public class Ville : Bdd
    {
        private int _idVille { get; set; }
        public int IdVille { get { return _idVille; } set { _idVille = value;  }  }

        private string _libelle { get; set; }
        public string Libelle { get { return _libelle; } set { _libelle = value; } }
        
        private string _codePostal { get; set; }
        public string CodePostal { get { return _codePostal; } set { _codePostal = value; } }

        private float _latitude { get; set; }
        public float Latitude { get { return _latitude; } set { _latitude = value; } }

        private float _longitude { get; set; }
        public float Longitude { get { return _longitude; } set { _longitude = value; } }

        private string _description { get; set; }
        public string Description { get { return _description; } set { _description = value; } }

        private string _uuid { get; set; }
        public string Uuid { get { return _uuid; } set { _uuid = value; } }

        private Region _region { get; set; }
        public Region Region { get { return _region; } set { _region = value; } }

        private List<Hebergement> _listHebergements;
        public List<Hebergement> ListHebergements { get { return _listHebergements; } set { _listHebergements = value; } }

        public Ville(int idVille = 0)
        {
            if(idVille != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM villes WHERE idVille = @idVille";
                query.Parameters.AddWithValue("@idVille", idVille);
                MySqlDataReader reader = query.ExecuteReader();
                int idRegion = 0;
                while (reader.Read())
                {
                    this.IdVille = reader.GetInt32(0);
                    this.Libelle = reader.GetString(1);
                    this.CodePostal = reader.GetString(2);
                    this.Latitude = reader.GetFloat(3);
                    this.Longitude = reader.GetFloat(4);
                    idRegion = reader.GetInt32(5);
                    if (!reader.IsDBNull(reader.GetOrdinal("description"))) { this.Description = reader.GetString(6); } else { this.Description = ""; }
                    if (!reader.IsDBNull(reader.GetOrdinal("uuid"))) { this.Uuid = reader.GetString(7); } else { this.Uuid = ""; }
                }
                _bdd.Close();

                _bdd.Open();
                query.Parameters.AddWithValue("@idRegion", idRegion);
                query.CommandText = "SELECT * FROM regions WHERE idRegion = @idRegion";
                reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.Region = new Region(reader.GetInt32(0), reader.GetString(1), reader.GetFloat(2), reader.GetFloat(3), reader.GetInt32(4), reader.GetString(5));
                }
                _bdd.Close();

                _bdd.Open();
                _listHebergements = new List<Hebergement>();
                query.CommandText = "SELECT hebergement.*, villes.*, regions.*, utilisateurs.*, roles.*, villes.description as descriptionVille FROM hebergement INNER JOIN villes USING(idVille) INNER JOIN utilisateurs USING(idUtilisateur) INNER JOIN regions USING(idRegion) INNER JOIN roles USING(idRole) WHERE idVille = @idVille";
                reader = query.ExecuteReader();
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

                    Hebergement Hebergement = new Hebergement(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDouble(5), reader.GetDouble(6), reader.GetDecimal(7), uuid, reader.GetDateTime(10), reader.GetBoolean(11), Ville, Utilisateur);
                    _listHebergements.Add(Hebergement);
                }
                _bdd.Close();

            }
        }

        public Ville(int idVille, string libelle, string codePostal, float latitude, float longitude, string description, string uuid, Region region)
        {
            this.IdVille = idVille;
            this.Libelle = libelle;
            this.CodePostal = codePostal;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Region = region;
            this.Description = description;
            this.Uuid = uuid;
        }

        public List<Ville> GetAllVille()
        {
            _bdd.Open();

            List<Ville> Villes = new List<Ville>();

            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT villes.*, regions.*, villes.description as descriptionVille FROM villes INNER JOIN regions USING(idRegion)";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                string description;
                string uuid;
                if (!reader.IsDBNull(reader.GetOrdinal("descriptionVille"))) { description = reader.GetString(6); } else { description = ""; }
                if (!reader.IsDBNull(reader.GetOrdinal("uuid"))) { uuid = reader.GetString(7); } else { uuid = ""; }
                Region region = new Region(reader.GetInt32(8), reader.GetString(9), reader.GetFloat(10), reader.GetFloat(11), reader.GetInt32(12), reader.GetString(13));
                Ville ville = new Ville(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), description, uuid, region);

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

    }
}
