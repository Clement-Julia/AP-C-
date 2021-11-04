﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP.Model
{
    class Hebergement : Http
    {

        private int _idHebergement;
        public int IdHebergement { get { return _idHebergement; } set { _idHebergement = value } }

        private string _libelle;
        public string Libelle { get { return _libelle; } set { _libelle = value } }

        private string _description;
        public string Description { get { return _description; } set { _description = value } }

        private int _idVille;
        public int IdVille { get { return _idVille; } set { _idVille = value } }

        private int _latitude;
        public int Latitude { get { return _latitude; } set { _latitude = value } }

        private int _longitude;
        public int Longitude { get { return _longitude; } set { _longitude = value } }

        private int _prix;
        public int Prix { get { return _prix; } set { _prix = value } }

        private string _uuid;
        public string Uuid { get { return _uuid; } set { _uuid = value } }

        private int _idUtilisateur;
        public int IdUtilisateur { get { return _idUtilisateur; } set { _idUtilisateur = value } }

        public Hebergement(int IdHebergement = 0)
        {
            if (IdHebergement != 0)
            {
                _http.Open();
                MySqlCommand query = _http.CreateCommand();
                query.CommandText = "SELECT * FROM hebergements WHERE idHebergement = @idHebergement";
                query.Parameters.AddWithValue("@idHebergement", IdHebergement);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    this.IdHebergement = reader.GetInt32(0);
                    this.Libelle = reader.GetString(1);
                    this.Description = reader.GetString(2);
                    this.IdVille = reader.GetInt32(3);
                    this.Latitude = reader.GetInt32(4);
                    this.Longitude = reader.GetInt32(5);
                    this.Prix = reader.GetInt32(6);
                    this.Uuid = reader.GetString(7);
                    this.IdUtilisateur = reader.GetInt32(8);
                }
                _http.Close();
            }
        }

        public void InitialisationHebergement(int id, string libelle, string description, int idVille, int latitude, int longitude, int prix, string uuid, int idUtilisateur)
        {
            this.IdHebergement = id;
            this.Libelle = libelle;
            this.Description = description;
            this.IdVille = idVille;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Prix = prix;
            this.Uuid = uuid;
            this.IdUtilisateur = idUtilisateur;
        }

    }
}
