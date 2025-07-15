using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Dictionnaire dictionnaire;
    public MotADeviner motADeviner;
    public UIManager uiManager;

    void Start()
    {
        string motChoisi = dictionnaire.ChoisirMot();
        motADeviner.Initialiser(motChoisi);
    
        // ✅ Affiche le mot masqué dans le bon champ
        uiManager.AfficherMot(motADeviner.GetAffichageMot());

        // ✅ Efface l'ancien message
        uiManager.AfficherMessage("Bienvenue dans le jeu du Pendu !");

    }

    // Méthode appelée par le clavier pour jouer une lettre
    public void JouerLettre(char lettre)
    {
        bool bonneLettre = motADeviner.ProposerLettre(lettre);
        uiManager.AfficherMot(motADeviner.GetAffichageMot());

        if (motADeviner.EstTrouve())
        {
            uiManager.AfficherMessage("🎉 Gagné !");
        }
        else if (!bonneLettre)
        {
            // Incrémenter le nombre d’erreurs
        }
    }
}
