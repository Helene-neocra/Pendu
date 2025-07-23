using System.Collections.Generic;
using UnityEngine;

public class Dictionnaire : MonoBehaviour
{
    private List<string> mots = new List<string>();

    void Awake()
    {
        ChargerMotsDepuisFichier();
    }

    void ChargerMotsDepuisFichier()
    {
        TextAsset fichierTexte = Resources.Load<TextAsset>("mots");

        if (fichierTexte != null)
        {
            string[] lignes = fichierTexte.text.Split(new[] { '\r', '\n' }, System.StringSplitOptions.RemoveEmptyEntries);

            foreach (string ligne in lignes)
            {
                string mot = ligne.Trim().ToUpper();

                if (mot.Length >= 5 && mot.Length <= 10)
                {
                    mots.Add(mot);
                }
            }

            Debug.Log($"Nombre de mots chargés : {mots.Count}");
        }
        else
        {
            Debug.LogError("Fichier de mots non trouvé dans le dossier Resources.");
        }
    }

    public string ChoisirMot()
    {
        if (mots.Count == 0) return "ERREUR";
        int index = Random.Range(0, mots.Count);
        return mots[index];
    }
}