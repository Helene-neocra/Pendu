
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Audio;

public class MotADeviner : MonoBehaviour
{
    private string motSecret;
    private HashSet<char> lettresTrouvees = new HashSet<char>();
    [SerializeField]
    private AudioSource audioEffect;

    // Initialise le mot secret
    public void Initialiser(string mot)
    {
        motSecret = mot.ToUpper();
        lettresTrouvees.Clear();
    }

    // Ajoute une lettre proposée et retourne si elle est correcte
    public bool ProposerLettre(char lettre)
    {
        lettre = char.ToUpper(lettre);

        if (motSecret.Contains(lettre))
        {
            lettresTrouvees.Add(lettre);
            audioEffect.Play(); // Joue un son si la lettre est correcte
            return true;
        }

        return false;
    }

    // Retourne un affichage partiel du mot (ex: "_ E N _ _")
    public string GetAffichageMot()
    {
        StringBuilder affichage = new StringBuilder();

        foreach (char c in motSecret)
        {
            if (lettresTrouvees.Contains(c))
                affichage.Append(c + " ");
            else
                affichage.Append("_ ");
        }

        return affichage.ToString().TrimEnd();
    }

    // Retourne vrai si toutes les lettres ont été trouvées
    public bool EstTrouve()
    {
        foreach (char c in motSecret)
        {
            if (!lettresTrouvees.Contains(c))
                return false;
        }
        return true;
    }

    public string GetMotSecret()
    {
        return motSecret;
    }
}
