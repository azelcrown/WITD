using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerQuitarsonido : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Obtén el componente AudioSource del GameObject
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log ("(if this.gameObject.name == carta");
            if (this.gameObject.name == "carta")
            {
                GameManager.Instance.tengo_carta=true;
            }

            if (this.gameObject.name == "anillo")
            {
                GameManager.Instance.tengo_anillo=true;
            }

            if (this.gameObject.name == "guardapelo")
            {
                GameManager.Instance.tengo_guardapelo=true;
            }

            if (this.gameObject.name == "huevos")
            {
                GameManager.Instance.tengo_huevos=true;
            }

            if (this.gameObject.name == "nido")
            {
                GameManager.Instance.tengo_nido=true;
            }

            if (this.gameObject.name == "abrecartas")
            {
                GameManager.Instance.tengo_abrecartas=true;
            }

            // Desactiva el AudioSource al recoger el objeto
            if (audioSource != null)
            {
                audioSource.enabled = false;
            }
            
            Destroy(gameObject);
        }
    }
}