namespace projet_dev_app_caisse
{
    partial class Form1
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
            this.fruitsText = new System.Windows.Forms.Label();
            this.fruitsComboBox = new System.Windows.Forms.ComboBox();
            this.poidsTextBox = new System.Windows.Forms.TextBox();
            this.ajouterButton = new System.Windows.Forms.Button();
            this.nouveauPanierButton = new System.Windows.Forms.Button();
            this.PoidsText = new System.Windows.Forms.Label();
            this.supprimerButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listeProduitsBox = new System.Windows.Forms.ListBox();
            this.importerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // fruitsText
            // 
            this.fruitsText.AutoSize = true;
            this.fruitsText.Location = new System.Drawing.Point(102, 119);
            this.fruitsText.Name = "fruitsText";
            this.fruitsText.Size = new System.Drawing.Size(49, 16);
            this.fruitsText.TabIndex = 0;
            this.fruitsText.Text = "Produit";
            // 
            // fruitsComboBox
            // 
            this.fruitsComboBox.DropDownHeight = 90;
            this.fruitsComboBox.FormattingEnabled = true;
            this.fruitsComboBox.IntegralHeight = false;
            this.fruitsComboBox.Location = new System.Drawing.Point(105, 139);
            this.fruitsComboBox.Name = "fruitsComboBox";
            this.fruitsComboBox.Size = new System.Drawing.Size(121, 24);
            this.fruitsComboBox.TabIndex = 1;
            // 
            // poidsTextBox
            // 
            this.poidsTextBox.Location = new System.Drawing.Point(251, 142);
            this.poidsTextBox.Name = "poidsTextBox";
            this.poidsTextBox.Size = new System.Drawing.Size(100, 22);
            this.poidsTextBox.TabIndex = 2;
            // 
            // ajouterButton
            // 
            this.ajouterButton.Location = new System.Drawing.Point(372, 142);
            this.ajouterButton.Name = "ajouterButton";
            this.ajouterButton.Size = new System.Drawing.Size(75, 23);
            this.ajouterButton.TabIndex = 3;
            this.ajouterButton.Text = "+";
            this.ajouterButton.UseVisualStyleBackColor = true;
            this.ajouterButton.UseWaitCursor = true;
            this.ajouterButton.Click += new System.EventHandler(this.ajouterButton_Click);
            // 
            // nouveauPanierButton
            // 
            this.nouveauPanierButton.Location = new System.Drawing.Point(475, 56);
            this.nouveauPanierButton.Name = "nouveauPanierButton";
            this.nouveauPanierButton.Size = new System.Drawing.Size(193, 38);
            this.nouveauPanierButton.TabIndex = 4;
            this.nouveauPanierButton.Text = "Nouvelle commande";
            this.nouveauPanierButton.UseVisualStyleBackColor = true;
            this.nouveauPanierButton.Click += new System.EventHandler(this.nouveauPanierButton_Click);
            // 
            // PoidsText
            // 
            this.PoidsText.AutoSize = true;
            this.PoidsText.Location = new System.Drawing.Point(251, 119);
            this.PoidsText.Name = "PoidsText";
            this.PoidsText.Size = new System.Drawing.Size(38, 20);
            this.PoidsText.TabIndex = 5;
            this.PoidsText.Text = "Poids";
            this.PoidsText.UseCompatibleTextRendering = true;
            // 
            // supprimerButton
            // 
            this.supprimerButton.Location = new System.Drawing.Point(105, 300);
            this.supprimerButton.Name = "supprimerButton";
            this.supprimerButton.Size = new System.Drawing.Size(121, 46);
            this.supprimerButton.TabIndex = 7;
            this.supprimerButton.Text = "Supprimer";
            this.supprimerButton.UseVisualStyleBackColor = true;
            this.supprimerButton.Click += new System.EventHandler(this.supprimerButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listeProduitsBox
            // 
            this.listeProduitsBox.FormattingEnabled = true;
            this.listeProduitsBox.ItemHeight = 16;
            this.listeProduitsBox.Location = new System.Drawing.Point(105, 199);
            this.listeProduitsBox.Name = "listeProduitsBox";
            this.listeProduitsBox.Size = new System.Drawing.Size(342, 84);
            this.listeProduitsBox.TabIndex = 8;
            // 
            // importerButton
            // 
            this.importerButton.Location = new System.Drawing.Point(105, 24);
            this.importerButton.Name = "importerButton";
            this.importerButton.Size = new System.Drawing.Size(145, 70);
            this.importerButton.TabIndex = 9;
            this.importerButton.Text = "Importer Inventaire";
            this.importerButton.UseVisualStyleBackColor = true;
            this.importerButton.Click += new System.EventHandler(this.importerButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "imprimer_Button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.51397F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.48603F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(498, 199);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 84);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.importerButton);
            this.Controls.Add(this.listeProduitsBox);
            this.Controls.Add(this.supprimerButton);
            this.Controls.Add(this.PoidsText);
            this.Controls.Add(this.nouveauPanierButton);
            this.Controls.Add(this.ajouterButton);
            this.Controls.Add(this.poidsTextBox);
            this.Controls.Add(this.fruitsComboBox);
            this.Controls.Add(this.fruitsText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label fruitsText;
        private System.Windows.Forms.ComboBox fruitsComboBox;
        private System.Windows.Forms.TextBox poidsTextBox;
        private System.Windows.Forms.Button ajouterButton;
        private System.Windows.Forms.Button nouveauPanierButton;
        private System.Windows.Forms.Label PoidsText;
        private System.Windows.Forms.Button supprimerButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listeProduitsBox;
        private System.Windows.Forms.Button importerButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

