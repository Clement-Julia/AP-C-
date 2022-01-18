using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public Option(int? IdOption = 0)
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
            }
        }

        public void InitialisationOption(int id, string libelle, string icon)
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
                Option Option = new Option();
                Option.InitialisationOption(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
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
