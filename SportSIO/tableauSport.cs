using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SportSIO
{
    public partial class tableauSport : Form
    {
        private string connectionString = "server=localhost;database=bdSport;uid=root;pwd=;";
        public tableauSport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ChargerSportifs("");
            // ChargerGestion();

            cmbCritere.Items.Add("Ville");
            cmbCritere.Items.Add("Niveau d'expérience");
            cmbCritere.Items.Add("Nom du sport");
            cmbCritere.SelectedIndex = 0;

            ChargerSportifs("");

            
            cmbNiveau.Items.Add("Debutant");
            cmbNiveau.Items.Add("Confirme");
            cmbNiveau.Items.Add("Avance");
            cmbNiveau.Items.Add("Professionnel");
            cmbNiveau.SelectedIndex = 0;

            cmbSport.Items.Add("Football");
            cmbSport.Items.Add("Tennis");
            cmbSport.Items.Add("Judo");
            cmbSport.Items.Add("Natation");
            cmbSport.Items.Add("Basketball");
            cmbSport.Items.Add("Rugby");
            cmbSport.Items.Add("Course");
            cmbSport.SelectedIndex = 0;

            ChargerGestion();
        }

        private void ChargerGestion()
        {
            lvGestion.Items.Clear();

            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();

                    string requete = "SELECT idSportif, nom, prenom, dateNaissance, ville, niveauExperience, nomSport, rue, codePostal FROM Sportif";

                    MySqlCommand commande = new MySqlCommand(requete, connexion);
                    MySqlDataReader lecteur = commande.ExecuteReader();

                    while (lecteur.Read())
                    {
                        ListViewItem ligne = new ListViewItem(lecteur["nom"].ToString());
                        ligne.SubItems.Add(lecteur["prenom"].ToString());
                        ligne.SubItems.Add(Convert.ToDateTime(lecteur["dateNaissance"]).ToString("dd/MM/yyyy"));
                        ligne.SubItems.Add(lecteur["ville"].ToString());
                        ligne.SubItems.Add(lecteur["niveauExperience"].ToString());
                        ligne.SubItems.Add(lecteur["nomSport"].ToString());
                        ligne.SubItems.Add(lecteur["rue"].ToString());
                        ligne.SubItems.Add(lecteur["codePostal"].ToString());

                        ligne.Tag = lecteur["idSportif"];

                        lvGestion.Items.Add(ligne);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement : " + ex.Message);
                }
            }
        }

        private void ChargerSportifs(string filtreSQL)
        {
            lvSportifs.Items.Clear();

            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();

                    string requete = "SELECT nom, prenom, dateNaissance, ville, niveauExperience, nomSport FROM Sportif" + filtreSQL;

                    MySqlCommand commande = new MySqlCommand(requete, connexion);
                    MySqlDataReader lecteur = commande.ExecuteReader();

                    while (lecteur.Read())
                    {
                        ListViewItem ligne = new ListViewItem(lecteur["nom"].ToString());
                        ligne.SubItems.Add(lecteur["prenom"].ToString());
                        ligne.SubItems.Add(Convert.ToDateTime(lecteur["dateNaissance"]).ToString("dd/MM/yyyy"));
                        ligne.SubItems.Add(lecteur["ville"].ToString());
                        ligne.SubItems.Add(lecteur["niveauExperience"].ToString());
                        ligne.SubItems.Add(lecteur["nomSport"].ToString());

                        lvSportifs.Items.Add(ligne);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des sportifs : " + ex.Message);
                }
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string valeur = txtValeur.Text.Trim();
            string filtre = "";

            
            if (cmbCritere.SelectedItem != null && valeur != "")
            {
                string colonne = "";

                switch (cmbCritere.SelectedItem.ToString())
                {
                    case "Ville":
                        colonne = "ville";
                        break;
                    case "Niveau d'expérience":
                        colonne = "niveau"; 
                        break;
                    case "Nom du sport":
                        colonne = "sport"; 
                        break;
                }

                
                filtre = " WHERE " + colonne + " LIKE '%" + valeur + "%'";
            }

           
            ChargerSportifs(filtre);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Trim() == "" || txtPrenom.Text.Trim() == "" ||
                txtRue.Text.Trim() == "" || txtCodePostal.Text.Trim() == "" ||
                txtVille.Text.Trim() == "")
            {
                MessageBox.Show("Merci de remplir tous les champs avant d'ajouter un sportif.");
                return;
            }

            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();

                    string requete = "INSERT INTO Sportif (nom, prenom, dateNaissance, rue, codePostal, ville, niveauExperience, nomSport) " +
                                      "VALUES (@nom, @prenom, @dateNaissance, @rue, @codePostal, @ville, @niveau, @sport)";

                    MySqlCommand commande = new MySqlCommand(requete, connexion);
                    commande.Parameters.AddWithValue("@nom", txtNom.Text.Trim());
                    commande.Parameters.AddWithValue("@prenom", txtPrenom.Text.Trim());
                    commande.Parameters.AddWithValue("@dateNaissance", dtpNaissance.Value.Date);
                    commande.Parameters.AddWithValue("@rue", txtRue.Text.Trim());
                    commande.Parameters.AddWithValue("@codePostal", txtCodePostal.Text.Trim());
                    commande.Parameters.AddWithValue("@ville", txtVille.Text.Trim());
                    commande.Parameters.AddWithValue("@niveau", cmbNiveau.SelectedItem.ToString());
                    commande.Parameters.AddWithValue("@sport", cmbSport.SelectedItem.ToString());

                    commande.ExecuteNonQuery();

                    MessageBox.Show("Sportif ajouté avec succès !");

                    ViderFormulaire();
                    ChargerGestion();
                    ChargerSportifs("");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout : " + ex.Message);
                }
            }

        }

        private void ViderFormulaire()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtRue.Clear();
            txtCodePostal.Clear();
            txtVille.Clear();
            dtpNaissance.Value = DateTime.Now;
            cmbNiveau.SelectedIndex = 0;
            cmbSport.SelectedIndex = 0;
        }

        private void tabPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvGestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGestion.SelectedItems.Count > 0)
            {
                ListViewItem ligne = lvGestion.SelectedItems[0];

                txtNom.Text = ligne.SubItems[0].Text;
                txtPrenom.Text = ligne.SubItems[1].Text;
                dtpNaissance.Value = DateTime.ParseExact(ligne.SubItems[2].Text, "dd/MM/yyyy", null);
                txtVille.Text = ligne.SubItems[3].Text;
                cmbNiveau.SelectedItem = ligne.SubItems[4].Text;
                cmbSport.SelectedItem = ligne.SubItems[5].Text;
                txtRue.Text = ligne.SubItems[6].Text;
                txtCodePostal.Text = ligne.SubItems[7].Text;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
           
            if (lvGestion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Il faut d'abord sélectionner un sportif dans la liste.");
            }
            else
            {
                
                if (txtNom.Text == "" || txtPrenom.Text == "" || txtRue.Text == "" || txtCodePostal.Text == "" || txtVille.Text == "")
                {
                    MessageBox.Show("Tous les champs doivent être remplis.");
                }
                else
                {
                    
                    int id = int.Parse(lvGestion.SelectedItems[0].Tag.ToString());

                    MySqlConnection connexion = new MySqlConnection(connectionString);

                    try
                    {
                        connexion.Open();

                        string requete = "UPDATE Sportif SET nom = @nom, prenom = @prenom, dateNaissance = @date, rue = @rue, codePostal = @cp, ville = @ville, niveauExperience = @niveau, nomSport = @sport WHERE idSportif = @id";

                        MySqlCommand commande = new MySqlCommand(requete, connexion);

                        
                        commande.Parameters.AddWithValue("@nom", txtNom.Text);
                        commande.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                        commande.Parameters.AddWithValue("@date", dtpNaissance.Value);
                        commande.Parameters.AddWithValue("@rue", txtRue.Text);
                        commande.Parameters.AddWithValue("@cp", txtCodePostal.Text);
                        commande.Parameters.AddWithValue("@ville", txtVille.Text);
                        commande.Parameters.AddWithValue("@niveau", cmbNiveau.Text);
                        commande.Parameters.AddWithValue("@sport", cmbSport.Text);
                        commande.Parameters.AddWithValue("@id", id);

                       
                        commande.ExecuteNonQuery();

                        MessageBox.Show("Le sportif a bien été modifié.");

                       
                        ViderFormulaire();
                        ChargerGestion();
                        ChargerSportifs("");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }

                    
                    connexion.Close();
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
            if (lvGestion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Il faut d'abord sélectionner un sportif dans la liste.");
            }
            else
            {
                
                DialogResult reponse = MessageBox.Show("Voulez-vous vraiment supprimer ce sportif ?", "Confirmation", MessageBoxButtons.YesNo);

                if (reponse == DialogResult.Yes)
                {
                    
                    int id = int.Parse(lvGestion.SelectedItems[0].Tag.ToString());

                    MySqlConnection connexion = new MySqlConnection(connectionString);

                    try
                    {
                        connexion.Open();

                        string requete = "DELETE FROM Sportif WHERE idSportif = @id";

                        MySqlCommand commande = new MySqlCommand(requete, connexion);
                        commande.Parameters.AddWithValue("@id", id);

                        commande.ExecuteNonQuery();

                        MessageBox.Show("Le sportif a bien été supprimé.");

                        ViderFormulaire();
                        ChargerGestion();
                        ChargerSportifs("");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }

                    connexion.Close();
                }
            }
        }
    }
}
