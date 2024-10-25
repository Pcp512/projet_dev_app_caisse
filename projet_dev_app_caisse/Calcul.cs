using System;
using System.Collections.Generic;
using System.Linq;

public class Calcul
{
    private Dictionary<string, double> _fruitsEtPrix; // Renommé avec underscore pour clarté
    private Dictionary<string, double> panier;

    // Ajout de la propriété publique
    public Dictionary<string, double> FruitsEtPrix
    {
        get { return new Dictionary<string, double>(_fruitsEtPrix); }
    }

    public Calcul()
    {
        _fruitsEtPrix = new Dictionary<string, double>();
        panier = new Dictionary<string, double>();
    }

    public bool CheckFruitsEtPoids(string fruitsToCheck, double poidsToCheck)
    {
        if (!_fruitsEtPrix.ContainsKey(fruitsToCheck))
        {
            return false;
        }
        if (poidsToCheck <= 0)
        {
            return false;
        }
        return true;
    }

    public void AjouterProduit(string fruit, double poids)
    {
        if (CheckFruitsEtPoids(fruit, poids))
        {
            if (panier.ContainsKey(fruit))
            {
                panier[fruit] += poids;
            }
            else
            {
                panier[fruit] = poids;
            }
        }
        else
        {
            throw new ArgumentException("Produit invalide ou poids incorrect");
        }
    }

    public void SupprimerProduit(string fruit, double poids)
    {
        if (panier.ContainsKey(fruit))
        {
            panier[fruit] -= poids;
            if (panier[fruit] <= 0)
            {
                panier.Remove(fruit);
            }
        }
        else
        {
            throw new ArgumentException("Produit non trouvé dans le panier");
        }
    }

    public double CalculTotal()
    {
        double total = 0;
        foreach (var item in panier)
        {
            total += item.Value * _fruitsEtPrix[item.Key];
        }
        return total;
    }

    public void ChargerFruitsEtPrix(Dictionary<string, double> nouveauxFruitsEtPrix)
    {
        _fruitsEtPrix = nouveauxFruitsEtPrix;
    }

    public Dictionary<string, double> ObtenirContenuPanier()
    {
        return new Dictionary<string, double>(panier);
    }
}