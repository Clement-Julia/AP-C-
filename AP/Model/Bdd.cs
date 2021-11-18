using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.Model
{
    public class Bdd
    {

        protected MySqlConnection _bdd = new MySqlConnection("database=ppe; server=localhost; user id = root; pwd=");

    }
}
