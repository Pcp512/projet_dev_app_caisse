using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dev_app_caisse
{
    public partial class Form1 : Form
    {
        private DataImport importer;
        //private DataExport exporter;
        private Calcul calcul;
        private DataExport exporter;
        private List<string> ticketCaisse = new List<string>();

        public Form1()
        {
            InitializeComponent();
            importer = new DataImport();
            //exporter = new DataExport();
            calcul = new Calcul();
            exporter = new DataExport();
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fruit = fruitsComboBox.SelectedItem.ToString();
                double poids;
                if (Double.TryParse(poidsTextBox.Text, out poids))
                {
                    calcul.AjouterProduit(fruit, poids);
                    MettreAJourAffichagePanier();
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un poids valide.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du produit : " + ex.Message);
            }
        }

        private void nouveauPanierButton_Click(object sender, EventArgs e)
        {
            calcul = new Calcul();
            MettreAJourAffichagePanier();
            MessageBox.Show("Nouveau panier créé.");
        }

        private void supprimerButton_Click(object sender, EventArgs e)
        {
            if (listeProduitsBox.SelectedItem != null)
            {
                try
                {
                    // Extraire le nom du fruit et le poids de la chaîne sélectionnée
                    string selectedItem = listeProduitsBox.SelectedItem.ToString();
                    string[] parts = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None);
                    string fruit = parts[0];
                    double poids = double.Parse(parts[1].Replace(" kg", ""));

                    // Supprimer le produit via la classe Calcul
                    calcul.SupprimerProduit(fruit, poids);

                    // Mettre à jour l'affichage
                    MettreAJourAffichagePanier();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élément à supprimer.");
            }
        }

        private void ImporterFichier(string filePath)
        {
            try
            {
                importer.FilePath = filePath; // Mettez à jour le chemin du fichier dans DataImport
                var fruitsEtPrix = importer.importProduitsData();
                calcul.ChargerFruitsEtPrix(fruitsEtPrix);
                RemplirComboBoxFruits(fruitsEtPrix.Keys);
                MessageBox.Show("Données importées avec succès.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'importation des données : " + ex.Message);
            }
        }

        private void importerButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Sélectionner le fichier CSV des produits et prix",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "csv",
                Filter = "Fichiers CSV (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImporterFichier(openFileDialog1.FileName);
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                string filePath = openFileDialog1.FileName;
                var fruitsEtPrix = importer.importProduitsData();
                calcul.ChargerFruitsEtPrix(fruitsEtPrix);
                RemplirComboBoxFruits(fruitsEtPrix.Keys);
                MessageBox.Show("Données importées avec succès.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'importation des données : " + ex.Message);
            }
        }

        private void MettreAJourAffichagePanier()
        {
            var contenuPanier = calcul.ObtenirContenuPanier();
            listeProduitsBox.Items.Clear();

            foreach (var item in contenuPanier)
            {
                listeProduitsBox.Items.Add($"{item.Key} - {item.Value} kg");
            }

            // Mettre à jour le nombre de produits
            PoidsText.Text = $"Nombre de produits : {contenuPanier.Count}";

            // Si vous voulez aussi mettre à jour le ticket.txt immédiatement
            if (contenuPanier.Count > 0)
            {
                exporter.WriteReceipt(contenuPanier, calcul.FruitsEtPrix);
            }
        }

        private void RemplirComboBoxFruits(System.Collections.Generic.IEnumerable<string> fruits)
        {
            fruitsComboBox.Items.Clear();
            foreach (var fruit in fruits)
            {
                fruitsComboBox.Items.Add(fruit);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (calcul.ObtenirContenuPanier().Count == 0)
                {
                    MessageBox.Show("Le panier est vide. Veuillez ajouter des articles avant d'imprimer le ticket.");
                    return;
                }

                exporter.WriteReceipt(calcul.ObtenirContenuPanier(), calcul.FruitsEtPrix);
                string ticketPath = Path.Combine(Application.StartupPath, "ticket.txt");
                MessageBox.Show($"Ticket généré avec succès à l'emplacement :\n{ticketPath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération du ticket : " + ex.Message);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }


        // Autres méthodes et gestionnaires d'événements...
    }
}