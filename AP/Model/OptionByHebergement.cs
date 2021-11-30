using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP.Model
{
    public class OptionByHebergement : Bdd
    {

        private int _idHebergement;
        public int IdHebergement { get { return _idHebergement; } set { _idHebergement = value; } }

        private int _idOption;
        public int IdOption { get { return _idOption; } set { _idOption = value; } }

        public OptionByHebergement(int IdHebergement = 0)
        {
            if (IdOption != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM options_by_herbegerment WHERE idHebergement = @idHebergement";
                query.Parameters.AddWithValue("@idHebergement", IdHebergement);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdHebergement = reader.GetInt32(0);
                    this.IdOption = reader.GetInt32(1);
                }
                _bdd.Close();
            }
        }

        public void InitialisationHebergement(int idHebergement, int idOptions)
        {
            this.IdHebergement = idHebergement;
            this.IdOption = idOptions;
        }
    }
}
