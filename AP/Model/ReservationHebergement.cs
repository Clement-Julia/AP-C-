using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace AP.Model
{
    public class ReservationHebergement : Bdd
    {
        private int _idReservationHebergement { get; set; }
        public int IdReservationHebergement { get { return _idReservationHebergement; } set { _idReservationHebergement = value;  }  }

        private string _codeReservation { get; set; }
        public string CodeReservation { get { return _codeReservation; } set { _codeReservation = value; } }

        private decimal _prix { get; set; }
        public decimal Prix { get { return _prix; } set { _prix = value; } }

        private DateTime _dateDebut { get; set; }
        public DateTime DateDebut { get { return _dateDebut; } set { _dateDebut = value; } }

        private DateTime _dateFin { get; set; }
        public DateTime DateFin { get { return _dateFin; } set { _dateFin = value; } }

        private int _nbJours { get; set; }
        public int NbJours { get { return _nbJours; } set { _nbJours = value; } }

        private int _idVoyage { get; set; }
        public int IdVoyage { get { return _idVoyage; } set { _idVoyage = value; } }

        private int _idUtilisateur { get; set; }
        public int IdUtilisateur { get { return _idUtilisateur; } set { _idUtilisateur = value; } }

        private int _idHebergement { get; set; }
        public int IdHebergement { get { return _idHebergement; } set { _idHebergement = value; } }

        public ReservationHebergement(int idReservationHebergement = 0)
        {
            if(idReservationHebergement != 0)
            {
                _bdd.Open();
                MySqlCommand query = _bdd.CreateCommand();
                query.CommandText = "SELECT * FROM reservations_hebergement WHERE idReservationHebergement = @idReservationHebergement";
                query.Parameters.AddWithValue("@idReservationHebergement", idReservationHebergement);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdReservationHebergement = reader.GetInt32(0);
                    this.CodeReservation = reader.GetString(1);
                    this.Prix = reader.GetDecimal(2);
                    this.DateDebut = reader.GetDateTime(3);
                    this.DateFin = reader.GetDateTime(4);
                    this.NbJours = reader.GetInt32(5);
                    this.IdVoyage = reader.GetInt32(6);
                    this.IdUtilisateur = reader.GetInt32(7);
                    this.IdHebergement = reader.GetInt32(8);
                }
                _bdd.Close();
            }
        }

        public void InitialiserReservationHebergement(int idReservationHebergement, string codeReservation, decimal prix, DateTime dateDebut, DateTime dateFin, int nbJours, int idVoyage, int idUtilisateur, int idHebergement)
        {
            this.IdReservationHebergement = idReservationHebergement;
            this.CodeReservation = codeReservation;
            this.Prix = prix;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
            this.NbJours = nbJours;
            this.IdVoyage = idVoyage;
            this.IdUtilisateur = idUtilisateur;
            this.IdHebergement = idHebergement;
        }

        public Ville GetVilleInfos()
        {
            Ville Ville = new Ville();
            string descripton = "";

            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT villes.* FROM hebergement INNER JOIN villes USING(idVille) WHERE idHebergement = @idHebergement";
            query.Parameters.AddWithValue("@idHebergement", this.IdHebergement);
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("description"))) { descripton = reader.GetString(0); } else { descripton = ""; }
                Ville.InitialiserVille(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3), reader.GetFloat(4), reader.GetInt32(5), descripton, reader.GetString(7));
            }
            _bdd.Close();

            return Ville;
        }
        public List<ReservationHebergement> GetReservationAVenir(int idHebergement)
        {
            List<ReservationHebergement> reservationHebergements = new List<ReservationHebergement>();

            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT * FROM reservations_hebergement WHERE idHebergement = @idHebergement AND dateDebut > NOW() ORDER BY dateDebut";
            query.Parameters.AddWithValue("@idHebergement", idHebergement);
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                ReservationHebergement reservationHebergement = new ReservationHebergement();
                reservationHebergement.InitialiserReservationHebergement(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8));
                reservationHebergements.Add(reservationHebergement);
            }
            _bdd.Close();

            return reservationHebergements;
        }

        public ReservationHebergement GetReservationEnCours(int idHebergement)
        {
            ReservationHebergement reservationHebergement = new ReservationHebergement();

            _bdd.Open();
            MySqlCommand query = _bdd.CreateCommand();
            query.CommandText = "SELECT * FROM reservations_hebergement WHERE idHebergement = @idHebergement AND dateDebut < NOW() AND dateFin > NOW()";
            query.Parameters.AddWithValue("@idHebergement", idHebergement);
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                reservationHebergement.InitialiserReservationHebergement(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8));

            }
            _bdd.Close();

            return reservationHebergement;
        }

    }
}
