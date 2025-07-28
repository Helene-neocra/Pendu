using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Dictionnaire dictionnaire;
    public MotADeviner motADeviner;
    public UIManager uiManager;
    private int nbErreurs = 0;
    private int maxErreurs = 8;
    private bool jeuTermine = false;
    public PenduAffichage penduAffichage;
    public GameObject boutonRejouer;
    public Clavier clavier;
    void Start()
    {
        string motChoisi = dictionnaire.ChoisirMot();
        motADeviner.Initialiser(motChoisi);
    
        // Affiche le mot masqué dans le bon champ
        uiManager.AfficherMot(motADeviner.GetAffichageMot());

        // Efface l'ancien message
        uiManager.AfficherMessage("Bienvenue dans le jeu du Pendu !");

    }

    // Méthode appelée par le clavier pour jouer une lettre
    public bool JouerLettre(char lettre)
    {
        if (jeuTermine)
            return false; // On ne joue plus si le jeu est terminé
        bool bonneLettre = motADeviner.ProposerLettre(lettre);
        uiManager.AfficherMot(motADeviner.GetAffichageMot());
        //clavier.DesactiverClavier();

        if (motADeviner.EstTrouve())
        {
            jeuTermine = true;
            uiManager.AfficherMessage("Gagné !");
            AfficherBoutonRestart(true);
            clavier.DesactiverClavier();
        }
        else if (!bonneLettre)
        {
            nbErreurs++;
            // 👇 Active une étape du pendu
            penduAffichage.AfficherEtape(nbErreurs - 1);

            if (nbErreurs >= maxErreurs)
            {
                jeuTermine = true;
                uiManager.AfficherMessage("Perdu ! Le mot était : " + motADeviner.GetMotSecret());
                AfficherBoutonRestart(true);
                clavier.DesactiverClavier();
            }
        }
        return bonneLettre;
    }
    
    public void AfficherBoutonRestart(bool afficher)
    {
        boutonRejouer.SetActive(afficher);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
