using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Audio : MonoBehaviour
{
    public static Audio Instance;

    public AudioMixer audioMixer;
    public AudioSource musique;

    private void Awake()
    {
        // Empêche les doublons entre scènes
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Méthode appelée par les sliders
    public void ChangerVolumeAmbiance(float volumeDb)
    {
        audioMixer.SetFloat("AmbianceVolume", volumeDb);
    }

    public void ChangerVolumeEffets(float volumeDb)
    {
        audioMixer.SetFloat("SoundVolume", volumeDb);
    }

}
