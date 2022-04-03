using MySql.Data.MySqlClient;

namespace AP.Model
{
    public class Bdd
    {

        protected MySqlConnection _bdd = new MySqlConnection("database=apwebbts; server=localhost; user id = root; pwd=");

    }
}
