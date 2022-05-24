using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AP.Model
{
    public class Formule : Bdd
    {
        private int _idFormule;
        public int IdFormule { get { return _idFormule; } set { _idFormule = value; } }

        private string _libelle;
        public string Libelle { get { return _libelle; } set { _libelle = value; } }

        public Formule(int IdFormule = 0)
        {
            if (IdFormule != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM formules WHERE id_formule = @idFormule";
                query.Parameters.AddWithValue("@idFormule", IdFormule);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdFormule = reader.GetInt32(0);
                    this.Libelle = reader.GetString(1);
                }
                _bdd.Close();
            }

        }
        public Formule(int idFormule, string libelle)
        {
            this.IdFormule = idFormule;
            this.Libelle = libelle;
        }

        // On récupère toutes les formules
        public List<Formule> GetFormules()
        {
            _bdd.Open();
            List<Formule> ListeFormules = new List<Formule>();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT * FROM formules";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                Formule Formule = new Formule(reader.GetInt32(0), reader.GetString(1));
                ListeFormules.Add(Formule);
            }
            _bdd.Close();
            return ListeFormules;
        }

    }
}
