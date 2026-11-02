using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportSIO
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            
            if (txtLogin.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Il faut saisir un identifiant et un mot de passe !");
                return;
            }

            string connectionString = "server=localhost;database=bdSport;uid=root;pwd=;";

            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();

                    
                    string requete = "SELECT * FROM utilisateur WHERE login = @login AND motDePasse = @pwd";

                    MySqlCommand commande = new MySqlCommand(requete, connexion);
                    commande.Parameters.AddWithValue("@login", txtLogin.Text.Trim());
                    commande.Parameters.AddWithValue("@pwd", txtPassword.Text.Trim());

                    MySqlDataReader lecteur = commande.ExecuteReader();

                    // Si le lecteur trouve une ligne, c'est que les identifiants sont bons
                    if (lecteur.Read())
                    {
                        MessageBox.Show("Connexion réussie !");

                        // J'ouvre la fenêtre principale (tableauSport)
                        tableauSport fenetrePrincipale = new tableauSport();
                        fenetrePrincipale.Show();

                        // Je cache la fenêtre de connexion
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login ou mot de passe incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }
    }
}
