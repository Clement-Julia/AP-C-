using MySql.Data.MySqlClient;

namespace AP.Model
{
    public class Bdd
    {

        protected MySqlConnection _bdd = new MySqlConnection("database=apwebbts2; server=localhost; user id = root; pwd=");

    }
}
