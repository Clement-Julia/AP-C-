using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AP.Model
{
    public class Role : Bdd
    {

        private int _idRole;
        public int IdRole { get { return _idRole; } set { _idRole = value; } }

        private string _libelle;
        public string Libelle { get { return _libelle; } set { _libelle = value; } }

        public Role(int idRole = 0)
        {
            if (idRole != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM roles WHERE idRole = @idRole";
                query.Parameters.AddWithValue("@idRole", IdRole);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdRole = reader.GetInt32(0);
                    this.Libelle = reader.GetString(1);
                }
                _bdd.Close();
            }
        }

        public Role(int idRole, string libelle)
        {
            this.IdRole = idRole;
            this.Libelle = libelle;
        }

    }
}
