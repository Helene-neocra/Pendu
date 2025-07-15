using UnityEngine;

public class PenduAffichage : MonoBehaviour
{
    public GameObject[] Pendu;

    public void AfficherEtape(int index)
    {
        if (index < 0 || index >= Pendu.Length)
            return;

        // Si on est à la dernière étape, n'afficher QUE celle-là
        if (index == Pendu.Length - 1)
        {
            // Tout cacher
            foreach (GameObject etape in Pendu)
            {
                etape.SetActive(false);
            }

            // Afficher seulement la dernière
            Pendu[index].SetActive(true);
        }
        else
        {
            // Affichage classique (cumulatif)
            Pendu[index].SetActive(true);
        }
    }

    public void ResetAffichage()
    {
        foreach (GameObject etape in Pendu)
        {
            etape.SetActive(false);
        }
    }
}

