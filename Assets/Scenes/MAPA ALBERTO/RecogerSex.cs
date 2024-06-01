using System.Collections;
using UnityEngine;

public class RecogerSex : MonoBehaviour
{
    private GameObject audioSourceGameObject;

    void Start()
    {
        // Encuentra el componente AudioSource en el GameObject hijo
        AudioSource audioSource = GetComponentInChildren<AudioSource>();
        if (audioSource != null)
        {
            audioSourceGameObject = audioSource.gameObject;
        }
        else
        {
            Debug.LogWarning("No se encontró un AudioSource en los hijos de " + gameObject.name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("(if this.gameObject.name == carta");

            if (this.gameObject.name == "carta")
            {
                GameManager.Instance.tengo_carta = true;
            }
            else if (this.gameObject.name == "anillo")
            {
                GameManager.Instance.tengo_anillo = true;
            }
            else if (this.gameObject.name == "guardapelo")
            {
                GameManager.Instance.tengo_guardapelo = true;
            }
            else if (this.gameObject.name == "huevos")
            {
                GameManager.Instance.tengo_huevos = true;
            }
            else if (this.gameObject.name == "nido")
            {
                GameManager.Instance.tengo_nido = true;
            }
            else if (this.gameObject.name == "abrecartas")
            {
                GameManager.Instance.tengo_abrecartas = true;
            }

            // Destruir el GameObject del AudioSource asociado
            if (audioSourceGameObject != null)
            {
                Destroy(audioSourceGameObject);
                Debug.Log("GameObject del AudioSource destruido");
            }
            else
            {
                Debug.LogWarning("No se pudo destruir el GameObject del AudioSource porque no se encontró uno.");
            }
        }
    }
}