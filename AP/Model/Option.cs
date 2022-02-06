using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AP.Model
{
    public class Option : Bdd
    {

        private int _idOption;
        public int IdOption { get { return _idOption; } set { _idOption = value; } }

        private string _libelle;
        public string Libelle { get { return _libelle; } set { _libelle = value; } }

        private string _icon;
        public string Icon { get { return _icon; } set { _icon = value; } }

        private List<Hebergement> _listHebergements;
        public List<Hebergement> ListHebergements { get { return _listHebergements; } set { _listHebergements = value; } }

        public Option(int IdOption = 0)
        {
            if (IdOption != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM options WHERE idOption = @idOption";
                query.Parameters.AddWithValue("@idOption", IdOption);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdOption = reader.GetInt32(0);
                    this.Libelle = reader.GetString(1);
                    this.Icon = reader.GetString(2);
                }
                _bdd.Close();

                _bdd.Open();
                _listHebergements = new List<Hebergement>();
                query.CommandText = "SELECT hebergement.*, villes.*, regions.*, utilisateurs.*, roles.*, hebergement.uuid as test, options_by_hebergement.*, villes.description as descriptionVille FROM options_by_hebergement INNER JOIN hebergement USING(idHebergement) INNER JOIN villes ON hebergement.idVille = villes.idVille INNER JOIN utilisateurs ON hebergement.idUtilisateur = utilisateurs.idUtilisateur INNER JOIN roles USING(idRole) INNER JOIN regions ON villes.idRegion = regions.idRegion WHERE options_by_hebergement.idOption = @idOption";
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

        public Option(int id, string libelle, string icon)
        {
            this.IdOption = id;
            this.Libelle = libelle;
            this.Icon = icon;
        }

        public List<Option> getAllOptions()
        {
            _bdd.Open();
            List<Option> Options = new List<Option>();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT * FROM options";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                Option Option = new Option(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                Options.Add(Option);
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
            _bdd.Close();

            if (name.Count > 0)
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

    }
}
