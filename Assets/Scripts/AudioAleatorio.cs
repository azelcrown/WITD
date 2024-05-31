using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAleatorio : MonoBehaviour
{
    public AudioClip clipDeSonido;  // El clip de sonido a reproducir
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = clipDeSonido;
        StartCoroutine(ReproducirSonidoAleatorio());
    }

    IEnumerator ReproducirSonidoAleatorio()
    {
        while (true)
        {
            // Esperar un tiempo aleatorio entre 10 y 60 segundos
            float tiempoEspera = Random.Range(1f, 120f);
            yield return new WaitForSeconds(tiempoEspera);

            // Iniciar la transición de volumen de entrada
            StartCoroutine(FadeIn(audioSource, 1f));

            // Reproducir el sonido
            audioSource.Play();

            // Esperar hasta que el sonido esté a punto de terminar
            yield return new WaitForSeconds(audioSource.clip.length - 1f);

            // Iniciar la transición de volumen de salida
            StartCoroutine(FadeOut(audioSource, 1f));

            // Esperar hasta que el sonido termine de reproducirse
            while (audioSource.isPlaying)
            {
                yield return null;
            }
        }
    }

    public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime)
    {
        float startVolume = 0.2f;

        audioSource.volume = 0;
        while (audioSource.volume < startVolume)
        {
            audioSource.volume += startVolume * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.volume = startVolume;
    }

    public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = startVolume;
    }
}