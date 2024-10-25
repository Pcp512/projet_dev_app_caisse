using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dev_app_caisse
{
    class DataImport
    {

        private string filePath;
        public string FilePath { get => filePath; set => filePath = value; }
        public DataImport()
        {
            //V4 : le fichier de produits et prix à lire est situé à côté de l'application
            this.filePath = "produitsprix.csv";
        }

            /// <returns>Un dictionaire<string,double>, les noms des produits en clés, les prix en valeurs</returns>
            public Dictionary<string, double> importProduitsData()
            {

                Dictionary<string, double> bufferDictionary = new Dictionary<string, double>();

                try
                {
                    using (StreamReader sr = new StreamReader(this.filePath))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            // Découpage de chaque ligne sur ;
                            string[] produitsPrix = line.Split(';');

                            // Vérifier que le format de la ligne est correct (au moins 2 éléments)
                            if (produitsPrix.Length >= 2)
                            {
                                // Convertir la deuxième partie (prix) en double
                                if (double.TryParse(produitsPrix[1], out double prix))
                                {
                                    // Ajouter au dictionnaire buffer la première partie en clé (produit)
                                    // et la deuxième partie en valeur (prix)
                                    bufferDictionary.Add(produitsPrix[0], prix);
                                }
                                else
                                {
                                    Console.WriteLine($"Erreur lors de la conversion du prix pour le produit {produitsPrix[0]}.");
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("Le fichier n'a pas pu être lu :");
                    Console.WriteLine(e.Message);
                }

                return bufferDictionary;
            }
        }
    } 