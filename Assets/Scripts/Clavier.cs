using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clavier : MonoBehaviour
{
    public GameManager gameManager;
    public Button[] boutonsLettre;

    void Start()
    {
        foreach (Button bouton in boutonsLettre)
        {
            string lettreLocal = bouton.GetComponentInChildren<TMPro.TextMeshProUGUI>().text;

            bouton.onClick.AddListener(() =>
            {
                Debug.Log("Lettre cliquée : " + lettreLocal);
                gameManager.JouerLettre(lettreLocal[0]);
                OnLettreCliquee(lettreLocal[0]);
                bouton.interactable = false;
                
            });
        }
    }
    
    void OnLettreCliquee(char lettre)
    {
        Debug.Log("Lettre cliquée : " + lettre);
        gameManager.JouerLettre(lettre);
    }
}