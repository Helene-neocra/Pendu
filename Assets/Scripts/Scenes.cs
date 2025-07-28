using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
       // SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void LancerJeu()
    {
        SceneManager.LoadScene("GamePlay"); // Remplace "GamePlay" par le nom exact de ta scène de jeu
    }
}
