using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoAleatorio : MonoBehaviour
{
    public AudioSource audioSource; // Referencia al AudioSource
    public float minDelay = 1.0f; // Retraso mínimo antes de reproducir el sonido
    public float maxDelay = 5.0f; // Retraso máximo antes de reproducir el sonido

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlaySound();
    }

    void PlaySound()
    {
        audioSource.Play();

        // Calcula un retraso aleatorio
        float delay = Random.Range(minDelay, maxDelay);

        // Programa la próxima reproducción del sonido
        Invoke("PlaySound", delay);
    }
}
