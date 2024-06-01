using UnityEngine;
using System.Collections.Generic;

public class Recoger : MonoBehaviour
{
    void Start()
    {
        
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
            
            Destroy(gameObject);
        }
    }
}