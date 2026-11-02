using System.Windows.Forms;

namespace SportSIO
{
    partial class tableauSport: Form 
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCritere = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lvSportifs = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prénom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lvGestion = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSport = new System.Windows.Forms.Label();
            this.txtNiveau = new System.Windows.Forms.Label();
            this.cmbSport = new System.Windows.Forms.ComboBox();
            this.cmbNiveau = new System.Windows.Forms.ComboBox();
            this.dtnNaiss = new System.Windows.Forms.Label();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.tabPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "critère de recherche :";
            // 
            // cmbCritere
            // 
            this.cmbCritere.FormattingEnabled = true;
            this.cmbCritere.Location = new System.Drawing.Point(172, 64);
            this.cmbCritere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCritere.Name = "cmbCritere";
            this.cmbCritere.Size = new System.Drawing.Size(160, 24);
            this.cmbCritere.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valeur : ";
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(503, 64);
            this.txtValeur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(132, 22);
            this.txtValeur.TabIndex = 3;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(52, 122);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(100, 28);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lvSportifs
            // 
            this.lvSportifs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Prénom,
            this.ColumnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvSportifs.FullRowSelect = true;
            this.lvSportifs.GridLines = true;
            this.lvSportifs.HideSelection = false;
            this.lvSportifs.Location = new System.Drawing.Point(52, 158);
            this.lvSportifs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvSportifs.Name = "lvSportifs";
            this.lvSportifs.Size = new System.Drawing.Size(804, 237);
            this.lvSportifs.TabIndex = 5;
            this.lvSportifs.UseCompatibleStateImageBehavior = false;
            this.lvSportifs.View = System.Windows.Forms.View.Details;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 100;
            // 
            // Prénom
            // 
            this.Prénom.Text = "Prénom";
            this.Prénom.Width = 100;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "date naissance";
            this.ColumnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ville";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Niveau";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sport";
            this.columnHeader6.Width = 100;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabPage1);
            this.tabPrincipal.Controls.Add(this.tabPage2);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 5);
            this.tabPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1061, 549);
            this.tabPrincipal.TabIndex = 6;
            this.tabPrincipal.SelectedIndexChanged += new System.EventHandler(this.tabPrincipal_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRechercher);
            this.tabPage1.Controls.Add(this.lvSportifs);
            this.tabPage1.Controls.Add(this.txtValeur);
            this.tabPage1.Controls.Add(this.cmbCritere);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1053, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "consultation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-316, -144);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, -196);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, -192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valeur : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-208, -196);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-360, -192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "critère de recherche :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtVille);
            this.tabPage2.Controls.Add(this.txtRue);
            this.tabPage2.Controls.Add(this.txtPrenom);
            this.tabPage2.Controls.Add(this.txtCodePostal);
            this.tabPage2.Controls.Add(this.txtNom);
            this.tabPage2.Controls.Add(this.btnSupprimer);
            this.tabPage2.Controls.Add(this.btnModifier);
            this.tabPage2.Controls.Add(this.btnAjouter);
            this.tabPage2.Controls.Add(this.lvGestion);
            this.tabPage2.Controls.Add(this.txtSport);
            this.tabPage2.Controls.Add(this.txtNiveau);
            this.tabPage2.Controls.Add(this.cmbSport);
            this.tabPage2.Controls.Add(this.cmbNiveau);
            this.tabPage2.Controls.Add(this.dtnNaiss);
            this.tabPage2.Controls.Add(this.dtpNaissance);
            this.tabPage2.Controls.Add(this.lblVille);
            this.tabPage2.Controls.Add(this.lblCodePostal);
            this.tabPage2.Controls.Add(this.lblRue);
            this.tabPage2.Controls.Add(this.lblPrenom);
            this.tabPage2.Controls.Add(this.lblNom);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1053, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(564, 140);
            this.txtVille.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(132, 22);
            this.txtVille.TabIndex = 19;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(564, 94);
            this.txtRue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(132, 22);
            this.txtRue.TabIndex = 18;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(585, 52);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(132, 22);
            this.txtPrenom.TabIndex = 17;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(181, 90);
            this.txtCodePostal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(132, 22);
            this.txtCodePostal.TabIndex = 16;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(137, 47);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(132, 22);
            this.txtNom.TabIndex = 15;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(429, 255);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimer.TabIndex = 14;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(249, 255);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 28);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(85, 255);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 28);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lvGestion
            // 
            this.lvGestion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lvGestion.FullRowSelect = true;
            this.lvGestion.GridLines = true;
            this.lvGestion.HideSelection = false;
            this.lvGestion.Location = new System.Drawing.Point(85, 290);
            this.lvGestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvGestion.Name = "lvGestion";
            this.lvGestion.Size = new System.Drawing.Size(805, 212);
            this.lvGestion.TabIndex = 11;
            this.lvGestion.UseCompatibleStateImageBehavior = false;
            this.lvGestion.View = System.Windows.Forms.View.Details;
            this.lvGestion.SelectedIndexChanged += new System.EventHandler(this.lvGestion_SelectedIndexChanged);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Nom";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Prénom";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Date naissance";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Ville";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Niveau";
            this.columnHeader15.Width = 80;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Sport";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Rue";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Code Postal";
            this.columnHeader18.Width = 80;
            // 
            // txtSport
            // 
            this.txtSport.AutoSize = true;
            this.txtSport.Location = new System.Drawing.Point(512, 192);
            this.txtSport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSport.Name = "txtSport";
            this.txtSport.Size = new System.Drawing.Size(93, 16);
            this.txtSport.TabIndex = 10;
            this.txtSport.Text = "Nom du sport :";
            // 
            // txtNiveau
            // 
            this.txtNiveau.AutoSize = true;
            this.txtNiveau.Location = new System.Drawing.Point(81, 192);
            this.txtNiveau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNiveau.Name = "txtNiveau";
            this.txtNiveau.Size = new System.Drawing.Size(137, 16);
            this.txtNiveau.TabIndex = 9;
            this.txtNiveau.Text = "Niveau d\'expérience :";
            // 
            // cmbSport
            // 
            this.cmbSport.FormattingEnabled = true;
            this.cmbSport.Location = new System.Drawing.Point(621, 188);
            this.cmbSport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSport.Name = "cmbSport";
            this.cmbSport.Size = new System.Drawing.Size(160, 24);
            this.cmbSport.TabIndex = 8;
            // 
            // cmbNiveau
            // 
            this.cmbNiveau.FormattingEnabled = true;
            this.cmbNiveau.Location = new System.Drawing.Point(236, 182);
            this.cmbNiveau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNiveau.Name = "cmbNiveau";
            this.cmbNiveau.Size = new System.Drawing.Size(160, 24);
            this.cmbNiveau.TabIndex = 7;
            // 
            // dtnNaiss
            // 
            this.dtnNaiss.AutoSize = true;
            this.dtnNaiss.Location = new System.Drawing.Point(81, 148);
            this.dtnNaiss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dtnNaiss.Name = "dtnNaiss";
            this.dtnNaiss.Size = new System.Drawing.Size(129, 16);
            this.dtnNaiss.TabIndex = 6;
            this.dtnNaiss.Text = "Date de Naissance :";
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.Location = new System.Drawing.Point(228, 140);
            this.dtpNaissance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(265, 22);
            this.dtpNaissance.TabIndex = 5;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(513, 148);
            this.lblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(39, 16);
            this.lblVille.TabIndex = 4;
            this.lblVille.Text = "Ville :";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(81, 96);
            this.lblCodePostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(86, 16);
            this.lblCodePostal.TabIndex = 3;
            this.lblCodePostal.Text = "Code postal :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(512, 98);
            this.lblRue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(38, 16);
            this.lblRue.TabIndex = 2;
            this.lblRue.Text = "Rue :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(512, 55);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(60, 16);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(83, 55);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 16);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            //
            // tableauSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "tableauSport";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCritere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.ListView lvSportifs;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prénom;
        private System.Windows.Forms.ColumnHeader ColumnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label dtnNaiss;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.ListView lvGestion;
        private System.Windows.Forms.Label txtSport;
        private System.Windows.Forms.Label txtNiveau;
        private System.Windows.Forms.ComboBox cmbSport;
        private System.Windows.Forms.ComboBox cmbNiveau;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
    }
}

