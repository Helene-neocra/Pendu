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
                bool bonneLettre = gameManager.JouerLettre(lettreLocal[0]);
                var image = bouton.GetComponent<Image>();
                if (image != null)
                {
                    if (bonneLettre)
                    {
                        image.color = Color.green;
                    }
                    else
                    {
                        image.color = Color.red;
                    }
                    bouton.onClick.RemoveAllListeners(); // Empêche un second clic
                }
            });
        }
    }
    public void DesactiverClavier()
    {
        foreach (Button bouton in boutonsLettre)
        {
            bouton.interactable = false;
        }
    }
}