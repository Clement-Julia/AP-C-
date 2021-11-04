using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AP
{
    public partial class modifHebergement : Form
    {
        int idHebergement = 0;
        int idVille = 0;
        int open = 0;
        int option = 0;

        public modifHebergement()
        {
            InitializeComponent();

            MySqlConnection conn = new MySqlConnection("database=ppe; server=localhost; user id = root; pwd=");
            conn.Open();


            //Initialisation des valeurs du menu de base
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", 23);
            command.CommandText = "SELECT libelle, description, prix, latitude, longitude, idVille, idHebergement FROM hebergement WHERE idHebergement = @id";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                name.Text = reader.GetString(0);
                description.Text = reader.GetString(1);
                prix.Text = reader.GetString(2);
                latitude.Text = reader.GetString(3);
                longitude.Text = reader.GetString(4);
                idVille = reader.GetInt32(5);
                idHebergement = reader.GetInt32(6);
            }
            conn.Close();

            conn.Open();
            MySqlCommand test = conn.CreateCommand();
            test.Parameters.AddWithValue("@ville", idVille);
            test.CommandText = "SELECT libelle, idVille FROM villes";
            MySqlDataReader reader2 = test.ExecuteReader();
            while (reader2.Read())
            {
                if (reader2.GetInt32(1) == idVille)
                {
                    ville.Text = reader2.GetString(0);
                }
                else
                {
                    ville.Items.Add(reader2.GetString(0));
                }
            }
            conn.Close();



            //Initialisation du menu option
            conn.Open();
            List<string> check = new List<string>();
            MySqlCommand recup_option = conn.CreateCommand();
            recup_option.Parameters.AddWithValue("@idHebergement", idHebergement);
            recup_option.CommandText = "SELECT libelle, options_by_hebergement.idOption from options_by_hebergement inner join options using(idOption) where idHebergement = @idHebergement";
            MySqlDataReader reader_option = recup_option.ExecuteReader();
            while (reader_option.Read())
            {
                check.Add(reader_option.GetString(0));
            }
            conn.Close();


            conn.Open();
            List<string> all = new List<string>();
            MySqlCommand recup_options = conn.CreateCommand();
            recup_options.CommandText = "SELECT libelle from options";
            MySqlDataReader reader_options = recup_options.ExecuteReader();
            while (reader_options.Read())
            {
                all.Add(reader_options.GetString(0));
            }
            option = all.Count;
            conn.Close();

            CheckBox[] ontest = new CheckBox[all.Count];
            for (int i = 0; i < all.Count; i++)
            {
                ontest[i] = new CheckBox();
                ontest[i].Text = all[i];
                ontest[i].Name = "option" + i;
                ontest[i].Anchor = AnchorStyles.None;
                ontest[i].Size = new Size(250, 21);
                for (int x = 0; x < check.Count; x++)
                {
                    if (all[i] == check[x])
                    {
                        ontest[i].Checked = true;
                    }
                }

                float_options.Controls.Add(ontest[i]);
            }
            conn.Close();



            //Initialisation menu avis
            conn.Open();
            List<string> nom = new List<string>();
            List<string> prenom = new List<string>();
            List<int> note = new List<int>();
            List<string> avis = new List<string>();
            List<int> idAvis = new List<int>();

            MySqlCommand recup_avis = conn.CreateCommand();
            recup_avis.Parameters.AddWithValue("@idHebergement", idHebergement);
            recup_avis.CommandText = "SELECT nom, prenom, note, commentaire, idAvis FROM avis inner JOIN utilisateurs using(idutilisateur) where idHebergement = @idHebergement";
            MySqlDataReader reader_avis = recup_avis.ExecuteReader();
            while (reader_avis.Read())
            {
                nom.Add(reader_avis.GetString(0));
                prenom.Add(reader_avis.GetString(1));
                note.Add(reader_avis.GetInt32(2));
                avis.Add(reader_avis.GetString(3));
                idAvis.Add(reader_avis.GetInt32(4));
            }
            conn.Close();

            Label[] user_name = new Label[nom.Count];
            Label[] user_lastname = new Label[prenom.Count];
            Label[] user_note = new Label[note.Count];
            Label[] user_avis = new Label[avis.Count];
            int[] user_idavis = new int[idAvis.Count];
            for (int i = 0; i < nom.Count; i++)
            {
                user_name[i] = new Label();
                user_lastname[i] = new Label();
                user_note[i] = new Label();
                user_avis[i] = new Label();
                Panel stock = new Panel();
                FlowLayoutPanel doble = new FlowLayoutPanel();
                PictureBox star = new PictureBox();
                LinkLabel answer = new LinkLabel();

                user_name[i].Text = nom[i];
                user_name[i].AutoSize = true;
                user_lastname[i].Text = prenom[i];
                user_note[i].Text = note[i].ToString();
                user_note[i].AutoSize = true;
                user_avis[i].Text = avis[i];
                user_avis[i].Size = new Size(300, 50);
                
                stock.BackColor = SystemColors.Control;
                stock.Size = new Size(300, 100);
                stock.Padding = new Padding(10, 10, 10, 0);
                
                doble.Dock = DockStyle.Fill;

                star.Image = Image.FromFile(@"C:\wamp64\www\Projet\AP\AP\src\rating2.png");
                star.Size = new Size(28, 17);
                star.SizeMode = PictureBoxSizeMode.Zoom;

                answer.Text = "Y répondre";
                answer.Name = "answer" + i;

                flow_avis.Controls.Add(stock);
                stock.Controls.Add(doble);
                doble.Controls.Add(user_name[i]);
                doble.Controls.Add(user_lastname[i]);
                doble.Controls.Add(user_note[i]);
                doble.Controls.Add(star);
                doble.Controls.Add(user_avis[i]);
                doble.Controls.Add(answer);
            }

            //Vérification et avertissement si impossibilité de modifiation
            conn.Open();
            string result = null;
            MySqlCommand verif = conn.CreateCommand();
            verif.Parameters.AddWithValue("@idHebergement", idHebergement);
            verif.CommandText = "SELECT * FROM reservations_hebergement where idHebergement = @idHebergement and dateFin > now()";

            MySqlDataReader reader3 = verif.ExecuteReader();
            while (reader3.Read())
            {
                result = reader3.GetString(0);
            }
            conn.Close();
            
            if(result != null)
            {
                open = 1;
            }

            if(open == 1)
            {
                MessageBox.Show("L'herbegement est réservé par des utilisateurs\nToute modification apportée ne sera pas prise en compte", "Attention");
            }
        }

        private void modif_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("database=ppe; server=localhost; user id = root; pwd=");
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idHebergement", idHebergement);
            command.Parameters.AddWithValue("@libelle", name.Text);
            command.Parameters.AddWithValue("@desciption", description.Text);
            command.Parameters.AddWithValue("@prix", prix.Text);
            command.Parameters.AddWithValue("@latitude", latitude.Text);
            command.Parameters.AddWithValue("@longitude", longitude.Text);
            conn.Close();

            if (String.IsNullOrEmpty(name.Text) && String.IsNullOrEmpty(prix.Text) && String.IsNullOrEmpty(latitude.Text) && String.IsNullOrEmpty(longitude.Text))
            {
                MessageBox.Show("Les informations ne peuvent pas être vides");
            }else if(open == 1)
            {
                MessageBox.Show("L'hebegement est réservé\nIl ne peut pas être modifié", "Attention");
            }
            else
            {
                conn.Open();
                MySqlCommand recup = conn.CreateCommand();
                recup.Parameters.AddWithValue("@libelle_ville", ville.Text);
                recup.CommandText = "SELECT idVille from villes where libelle = @libelle_ville";
                MySqlDataReader recup_ville = recup.ExecuteReader();
                while (recup_ville.Read())
                {
                    command.Parameters.AddWithValue("@ville", recup_ville.GetInt32(0));
                }
                conn.Close();
                conn.Open();
                command.CommandText = "update hebergement set libelle = @libelle, description = @desciption, prix = @prix, idVille = @ville where idHebergement = @idHebergement";
                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Modification effectuée !");
                }
                else
                {
                    MessageBox.Show("Un problème est apparu veuillez recommencer");
                }
            }


            conn.Close();
        }
        
        private void modif2_Click(object sender, EventArgs e)
        {
            string req = "";

            MySqlConnection conn = new MySqlConnection("database=ppe; server=localhost; user id = root; pwd=");

            if(open != 1)
            {
                conn.Open();
                MySqlCommand supOption = conn.CreateCommand();
                supOption.Parameters.AddWithValue("@idHebergement", idHebergement);
                supOption.CommandText = "delete from options_by_hebergement where idHebergement = @idHebergement";
                supOption.ExecuteNonQuery();
                conn.Close();

                conn.Open();

                MySqlCommand ajoutOption = conn.CreateCommand();
                ajoutOption.Parameters.AddWithValue("@idHebergement", idHebergement);
                for (int i = 0; i < option; i++)
                {
                    foreach (CheckBox checkbox in float_options.Controls)
                    {
                        if (checkbox.Name == "option" + i)
                        {
                            if (checkbox.Checked == true)
                            {
                                conn.Close();
                                conn.Open();
                                MySqlCommand recup_libelle_option = conn.CreateCommand();
                                recup_libelle_option.Parameters.AddWithValue("@libelle", checkbox.Text);
                                recup_libelle_option.CommandText = "select idOption from options where libelle = @libelle";
                                MySqlDataReader reader_libelle_option = recup_libelle_option.ExecuteReader();
                                while (reader_libelle_option.Read())
                                {
                                    ajoutOption.Parameters.AddWithValue("@option" + i, reader_libelle_option.GetInt32(0));
                                }
                                conn.Close();
                                conn.Open();

                                req += "(@idHebergement, @option" + i + "),";
                            }
                        }
                    }
                }
                //req.Substring(0, req.Length - 1);
                req = req.TrimEnd(',');
                ajoutOption.CommandText = "insert into options_by_hebergement(idHebergement, idOption) values" + req;
                //MessageBox.Show(ajoutOption.CommandText);
                if (ajoutOption.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Modification effectuée !");
                }
                else
                {
                    MessageBox.Show("Un problème est apparu veuillez recommencer");
                }

                conn.Close();

            }
            else
            {
                MessageBox.Show("L'hebegement est réservé\nIl ne peut pas être modifié", "Attention");
            }
        }

        private void sup_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("database=ppe; server=localhost; user id = root; pwd=");
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            command.Parameters.AddWithValue("@idHebergement", idHebergement);

            if (open != 1)
            {
                var confirmResult = MessageBox.Show("Vous allez supprimer l'herbergement : " + name.Text + "\nÊtes-vous sûr ?", "Attention", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    command.CommandText = "DELETE FROM hebergement where idHebergement = @idHebergement";
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Suppression effectuée !\nVous avez bien supprimé : " + name.Text);
                    }
                    else
                    {
                        MessageBox.Show("Un problème est apparu veuillez recommencer");
                    }
                }
                else
                {
                    MessageBox.Show("La suppression à été annulé");
                }
            }
            else
            {
                MessageBox.Show("L'hebegement est réservé\nIl ne peut pas être supprimé", "Attention");
            }

            conn.Close();

            //Faire une redirection
        }

        private void retour_Click(object sender, EventArgs e)
        {
            //Faire une redirection
        }

    }
}
