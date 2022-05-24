using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AP.Model
{
    public class AssoHebergementFormule : Bdd
    {
        private int _idHebergement;
        public int IdHebergement { get { return _idHebergement; } set { _idHebergement = value; } }

        private int _idFormule;
        public int IdFormule { get { return _idFormule; } set { _idFormule = value; } }

        private decimal _prix = 0;
        public decimal Prix { get { return _prix; } set { _prix = value; } }

        private List<AssoHebergementFormule> _listAssoHebergementFormule;
        public List<AssoHebergementFormule> ListAssoHebergementFormule { get { return _listAssoHebergementFormule; } set { _listAssoHebergementFormule = value; } }

        public AssoHebergementFormule(int IdHebergement, int IdFormule, decimal Prix)
        {
            this.IdHebergement = IdHebergement;
            this.IdFormule = IdFormule;
            this.Prix = Prix;
        }

        public AssoHebergementFormule()
        {

        }

        // On va sauvegarder toutes les formules
        public bool UpdateFormules(List<AssoHebergementFormule> ListFormules, int idHebergement)
        {
            try
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "DELETE FROM asso_hebergement_formule WHERE id_hebergement = @idHebergement";
                query.Parameters.AddWithValue("@idHebergement", idHebergement);
                MySqlDataReader reader = query.ExecuteReader();
                _bdd.Close();

                foreach (AssoHebergementFormule Formule in ListFormules)
                {
                    if (Formule.Prix != 0)
                    {
                        _bdd.Open();
                        query = _bdd.CreateCommand();
                        query.CommandText = "INSERT INTO asso_hebergement_formule VALUE (@idHebergement, @idFormule, @prix)";
                        query.Parameters.AddWithValue("@idHebergement", idHebergement);
                        query.Parameters.AddWithValue("@idFormule", Formule.IdFormule);
                        query.Parameters.AddWithValue("@prix", Formule.Prix);
                        reader = query.ExecuteReader();
                        _bdd.Close();
                    }
                }

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

    }
}
