using MySql.Data.MySqlClient;
using System;

namespace AP.Model
{
    public class AdminValidHebergement : Bdd
    {

        private int _idAdminValidHebergement;
        public int IdAdminValidHebergement { get { return _idAdminValidHebergement; } set { _idAdminValidHebergement = value; } }

        private string _libelle;
        public string Libelle { get { return _libelle; } set { _libelle = value; } }

        private string _description;
        public string Description { get { return _description; } set { _description = value; } }

        private string _nomVille;
        public string NomVille { get { return _nomVille; } set { _nomVille = value; } }

        private string _codePostal;
        public string CodePostal { get { return _codePostal; } set { _codePostal = value; } }

        private string _adresse;
        public string Adresse { get { return _adresse; } set { _adresse = value; } }

        private float _latitude;
        public float Latitude { get { return _latitude; } set { _latitude = value; } }

        private float _longitude;
        public float Longitude { get { return _longitude; } set { _longitude = value; } }

        private decimal _prix;
        public decimal Prix { get { return _prix; } set { _prix = value; } }

        private int _idUtilisateur;
        public int IdUtilisateur { get { return _idUtilisateur; } set { _idUtilisateur = value; } }

        private DateTime _dateEnregistrement;
        public DateTime DateEnregistrement {  get { return _dateEnregistrement; } set { _dateEnregistrement = value; } }

        private Boolean _isActif;
        public Boolean IsActif {  get { return _isActif; } set { _isActif = value; } }

        private double _latitudeNewVille;
        public double LatitudeNewVille { get { return _latitudeNewVille; } set { _latitudeNewVille = value; } }

        private double _longitudeNewVille;
        public double LongitudeNewVille { get { return _longitudeNewVille; } set { _longitudeNewVille = value; } }

        private int _idRegion;
        public int IdRegion { get { return _idRegion; } set { _idRegion = value; } }

        public AdminValidHebergement(int IdUtilisateur = 0)
        {
            if (IdUtilisateur != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM admin_valid_hebergement WHERE idUtilisateur = @idUtilisateur";
                query.Parameters.AddWithValue("@idHebergement", IdUtilisateur);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdAdminValidHebergement = reader.GetInt32(0);
                    this.Libelle = reader.GetString(1);
                    this.Description = reader.GetString(2);
                    this.NomVille = reader.GetString(3);
                    this.CodePostal = reader.GetString(4);
                    this.Adresse = reader.GetString(5);
                    this.Latitude = reader.GetFloat(6);
                    this.Longitude = reader.GetFloat(7);
                    this.Prix = reader.GetInt32(8);
                    this.IdUtilisateur = reader.GetInt32(9);
                    this.DateEnregistrement = reader.GetDateTime(10);
                    this.IsActif = reader.GetBoolean(11);
                    if (!reader.IsDBNull(reader.GetOrdinal("latitudeVille"))) { LatitudeNewVille = reader.GetDouble(12); } else { LatitudeNewVille = 0; }
                    if (!reader.IsDBNull(reader.GetOrdinal("longitudeVille"))) { LongitudeNewVille = reader.GetDouble(13); } else { LongitudeNewVille = 0; }
                    this.IdRegion = reader.GetInt32(14);
                }
                _bdd.Close();
            }
        }

        public void InitialisationAdminValidHebergement(int id, string libelle, string description, string nomVille, string codePostal, string adresse, float latitude, float longitude, decimal prix, int idUtilisateur, DateTime dateEnregistrement, Boolean isActif, double latitudeVille, double longitudeVille, int idRegion)
        {
            this.IdAdminValidHebergement = id;
            this.Libelle = libelle;
            this.Description = description;
            this.NomVille = nomVille;
            this.CodePostal = codePostal;
            this.Adresse = adresse;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Prix = prix;
            this.IdUtilisateur = idUtilisateur;
            this.DateEnregistrement = dateEnregistrement;
            this.IsActif = isActif;
            this.LatitudeNewVille = latitudeVille;
            this.LongitudeNewVille = longitudeVille;
            this.IdRegion = idRegion;
        }

        public Boolean InsertAdminValidHebergement(string libelle, string description, string nomVille, string codePostal, string adresse, float latitude, float longitude, decimal prix, int idUtilisateur, int idRegion, double latitudeVille = 0, double longitudeVille = 0)
        {
            Boolean error = false;

            try
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                if(latitudeVille != 0 && longitudeVille != 0)
                {
                    query.CommandText = "INSERT INTO admin_valid_hebergements (libelle, description, nomVille, code_postal, adresse, latitude, longitude, prix, idUtilisateur, dateEnregistrement, is_actif, latitudeVille, longitudeVille, idRegion) VALUES(@libelle, @description, @nomVille, @code_postal, @adresse, @latitude, @longitude, @prix, @idUtilisateur, NOW(), 1, @latitudeVille, @longitudeVille, @idRegion)";
                    query.Parameters.AddWithValue("@latitudeVille", latitudeVille);
                    query.Parameters.AddWithValue("@longitudeVille", longitudeVille);
                }
                else
                {
                    query.CommandText = "INSERT INTO admin_valid_hebergements (libelle, description, nomVille, code_postal,  adresse, latitude, longitude, prix, idUtilisateur, dateEnregistrement, is_actif, idRegion) VALUES(@libelle, @description, @nomVille, @code_postal, @adresse, @latitude, @longitude, @prix, @idUtilisateur, NOW(), 1, @idRegion)";
                }
                query.Parameters.AddWithValue("@libelle", libelle);
                query.Parameters.AddWithValue("@description", description);
                query.Parameters.AddWithValue("@nomVille", nomVille);
                query.Parameters.AddWithValue("@code_postal", codePostal);
                query.Parameters.AddWithValue("@adresse", adresse);
                query.Parameters.AddWithValue("@latitude", latitude);
                query.Parameters.AddWithValue("@longitude", longitude);
                query.Parameters.AddWithValue("@prix", prix);
                query.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                query.Parameters.AddWithValue("@idRegion", idRegion);
                query.ExecuteNonQuery();
                _bdd.Close();
            }
            catch
            {
                // LEVEE D'UNE EXCEPTION
                error = true;
            }

            if (error)
                return false;
            else
                return true;

        }
    }
}
