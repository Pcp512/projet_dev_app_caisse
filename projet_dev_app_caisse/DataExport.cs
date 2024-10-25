using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace projet_dev_app_caisse
{
    public class DataExport
    {
        private string outputPath;

        public DataExport()
        {
            // Le fichier de ticket sera créé dans le même dossier que l'application
            outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ticket.txt");
        }

        public void WriteReceipt(Dictionary<string, double> panier, Dictionary<string, double> fruitsEtPrix)
        {
            try
            {
                StringBuilder ticket = new StringBuilder();

                // En-tête
                ticket.AppendLine("---------------------------");
                ticket.AppendLine("Primeur de la côte");
                ticket.AppendLine("Avenue de beaurivage");
                ticket.AppendLine("64200 Biarritz");
                ticket.AppendLine($"le {DateTime.Now:dd/MM/yyyy}");
                ticket.AppendLine($"à {DateTime.Now:HH:mm}");
                ticket.AppendLine();

                // Contenu du panier
                double totalHT = 0;
                foreach (var item in panier)
                {
                    string produit = item.Key;
                    double poids = item.Value;
                    double prixUnitaire = fruitsEtPrix[produit];
                    double prixLigne = poids * prixUnitaire;
                    totalHT += prixLigne;

                    ticket.AppendLine($"{produit} - {poids:F2} kg : {prixLigne:F2} €");
                }

                // Calculs TVA et total
                double tauxTVA = 0.20; // TVA à 20%
                double montantTVA = totalHT * tauxTVA;
                double totalTTC = totalHT + montantTVA;

                // Totaux
                ticket.AppendLine();
                ticket.AppendLine($"TOTAL TTC : {totalTTC:F2} €");
                ticket.AppendLine($"TVA: {montantTVA:F2} €");
                ticket.AppendLine();

                // Pied de page
                ticket.AppendLine("Merci de votre visite et...");
                ticket.AppendLine("... Gardez la pêche !");
                ticket.AppendLine("---------------------------");

                // Écriture dans le fichier
                File.WriteAllText(outputPath, ticket.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de l'écriture du ticket : {ex.Message}");
            }
        }
    }
}