using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionnaire : MonoBehaviour
{
   
    private List<string> mots = new List<string>
    {
        "PENDU",
        "DRAGON",
        "ORDINATEUR",
        "BOUTEILLE",
        "CHOCOLAT"
    };

    // Méthode pour choisir un mot au hasard
    public string ChoisirMot()
    {
        int index = UnityEngine.Random.Range(0, mots.Count);
        return mots[index];
    }
}
