using AP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP.UserControls
{
    public partial class AddPicture : UserControl
    {
        FlowLayoutPanel _parent;
        Hebergement _hebergement;
        List<PictureBox> allPictures = new List<PictureBox>();
        List<PictureBox> banniere = new List<PictureBox>();
        List<String> path = new List<String>();

        public AddPicture(FlowLayoutPanel flow_picture, Hebergement hebergement)
        {
            InitializeComponent();
            _parent = flow_picture;
            _hebergement = hebergement;
            FileDialog.Filter = "Image Files (JPG,PNG,JPEG)|*.JPG;*.PNG;*.JPEG";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Choix image et récupération de son chemin d'accès
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                string fichier = FileDialog.FileName;
                string name = FileDialog.SafeFileName;
                FileDialog.Dispose();

                // Vérification qu'un fichier a été choisi
                // Création d'une image temporaire
                Bitmap image;
                using (Bitmap bmp = new Bitmap(fichier))
                {
                    image = new Bitmap(bmp);
                }

                // Création de la PictureBox qui va afficher cette image
                PictureBox pictureCustom = new PictureBox();
                pictureCustom.Image = image;
                pictureCustom.ImageLocation = fichier;
                pictureCustom.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureCustom.Size = new Size(300, 150);
                pictureCustom.Click += new EventHandler(delete_picture);
                pictureCustom.AccessibleName = name;
                pictureCustom.Cursor = Cursors.Hand;

                // Ajout de la PictureBox dans la liste de toutes les pictureBox
                allPictures.Add(pictureCustom);

                // Affichage de la PictureBox sur le parent
                _parent.Controls.Add(pictureCustom);
            }
        }

        private void addBan_Click(object sender, EventArgs e)
        {
            // Choix image et récupération de son chemin d'accès
            if(FileDialog.ShowDialog() == DialogResult.OK)
            {
                string fichier = FileDialog.FileName;
                string name = FileDialog.SafeFileName;
                FileDialog.Dispose();

                // Création d'une image temporaire
                Bitmap image;
                using (Bitmap bmp = new Bitmap(fichier))
                {
                    image = new Bitmap(bmp);
                }

                // Création de la PictureBox qui va afficher cette image
                PictureBox pictureCustom = new PictureBox();
                pictureCustom.Image = image;
                pictureCustom.ImageLocation = fichier;
                pictureCustom.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureCustom.Size = new Size(300, 150);
                pictureCustom.Click += new EventHandler(delete_picture);
                pictureCustom.AccessibleName = name;
                pictureCustom.Cursor = Cursors.Hand;

                // Ajout de la PictureBox dans la liste de toutes les pictureBox
                banniere.Add(pictureCustom);

                // Affichage de la PictureBox sur le parent
                _parent.Controls.Add(pictureCustom);
            }
        }

        // Événement de suppression de PictureBox lors d'un click sur eux-mêmes
        private void delete_picture(object sender, EventArgs e)
        {
            PictureBox pictureClicked = (PictureBox)sender;
            if (allPictures.Contains(pictureClicked))
                allPictures.Remove(pictureClicked);
            else
                banniere.Remove(pictureClicked);
            _parent.Controls.Remove(pictureClicked);
        }

        private void formPicture_Click(object sender, EventArgs e)
        {
            string Uri = "ftp://ipssisq-loocalacool_ovh-41552@ftpcloud.cluster024.hosting.ovh.net:21/assets/src/tuuid/";
            bool exist = false;

            try
            {
                // Requête ftp vérifiant qu'une demande n'a pas déjà été faite
                FtpWebRequest Request = (FtpWebRequest)WebRequest.Create(Uri + _hebergement.Uuid + "/");
                Request.Method = WebRequestMethods.Ftp.ListDirectory;
                Request.Credentials = new NetworkCredential("ipssisq-loocalacool_ovh-41552", "Ipssi2022loocalacool");

                FtpWebResponse Response = (FtpWebResponse)Request.GetResponse();
                Stream ResponseStream = Response.GetResponseStream();
                StreamReader Reader = new StreamReader(ResponseStream);

                while (!Reader.EndOfStream)
                {
                    exist = true;
                    break;
                }
                Response.Close();
                ResponseStream.Close();
                Reader.Close();
            }
            catch
            {
                exist = false;
            }
            

            if (exist == false)
            {
                if (allPictures.Count() != 0 || banniere.Count() != 0)
                {
                    // Création du dossier sur le serv
                    FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(Uri + _hebergement.Uuid);
                    ftpRequest.Credentials = new NetworkCredential("ipssisq-loocalacool_ovh-41552", "Ipssi2022loocalacool");
                    ftpRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
                    WebResponse response = ftpRequest.GetResponse();
                    response.Close();

                    // Ajout de la banière s'il y en a une
                    if(banniere.Count() != 0)
                    {
                        foreach (PictureBox element in banniere.ToList())
                        {
                            string ext = Path.GetExtension(element.ImageLocation);
                            // Choix de l'emplacement du fichier ainsi que de son nom
                            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Uri + _hebergement.Uuid + "/banniere"+ext);
                            request.Method = WebRequestMethods.Ftp.UploadFile;

                            // Connexion ftp
                            request.Credentials = new NetworkCredential("ipssisq-loocalacool_ovh-41552", "Ipssi2022loocalacool");

                            // Envoie de l'image et fermeture du serveur pour ne pas passer en timeout
                            FileStream fileStream = File.Open(element.ImageLocation, FileMode.Open, FileAccess.Read);
                            Stream requestStream = request.GetRequestStream();
                            requestStream.Close();

                            // Suppression de la PictureBox dans le parent
                            _parent.Controls.Remove(element);
                            allPictures.Remove(element);
                        }
                    }

                    if (allPictures.Count() != 0)
                    {
                        int increment = 2;
                        foreach (PictureBox element in allPictures.ToList())
                        {
                            string ext = Path.GetExtension(element.ImageLocation);

                            // Choix de l'emplacement du fichier ainsi que de son nom
                            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Uri + _hebergement.Uuid + "/" + _hebergement.Libelle + increment + ext);
                            request.Method = WebRequestMethods.Ftp.UploadFile;

                            // Connexion ftp
                            request.Credentials = new NetworkCredential("ipssisq-loocalacool_ovh-41552", "Ipssi2022loocalacool");

                            // Envoie de l'image et fermeture du serveur pour ne pas passer en timeout
                            FileStream fileStream = File.Open(element.ImageLocation, FileMode.Open, FileAccess.Read);
                            Stream requestStream = request.GetRequestStream();
                            requestStream.Close();

                            // Suppression de la PictureBox dans le parent
                            _parent.Controls.Remove(element);
                            allPictures.Remove(element);
                            increment++;
                        }
                    }

                    MessageBox.Show("Demande envoyée");
                }
                else
                {
                    MessageBox.Show("Aucune image n'a été séléctionnée");
                }
            }
            else
            {
                MessageBox.Show("Une demande a déjà été faite attendez son acceptation ou demandez son annulation en écrivant un email à l'adresse suivante : loocalacool@service-support.fr");
            }
        }
    }
}
