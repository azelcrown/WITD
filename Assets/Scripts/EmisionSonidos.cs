using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EmisionSonidos : MonoBehaviour
{

    public AudioClip playerCall;
    public Transform playerTransform;
    public float maxDistance = 25f; //Distancia máximo para que el sonido de los bichos suene a tope
    private AudioSource playerAudioSource;

    private bool llamadaHecha = false;
    private bool permitirLlamada = true;
    

    // Start is called before the first frame update
    void Start()
    {
        playerAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(permitirLlamada && Input.GetKeyDown(KeyCode.Z) && !playerAudioSource.isPlaying){
            playerAudioSource.PlayOneShot(playerCall);
            permitirLlamada = false;
            
        }else{
            permitirLlamada = true;
        }
    }

    void OnTriggerStay(Collider col){

        //Debug.Log(playerAudioSource.isPlaying);

        if(col.gameObject.CompareTag("Bicho") && playerAudioSource.isPlaying){
           
           BichitosScript bichitos = col.GetComponent<BichitosScript>();
            if (bichitos != null)
            {
                if (!llamadaHecha)
                {
                    StartCoroutine(Respuesta(bichitos));
                    llamadaHecha = true;
                }
            Debug.Log("Gritan los bichoss");
            }
        }
    } 

    void OnTriggerExit(Collider col){

        if(col.gameObject.CompareTag("Bicho")){

            
            BichitosScript bichitos = col.GetComponent<BichitosScript>();
            bichitos.ExitedPlayerTrigger();
            Debug.Log("No Gritan los bichos");
        }
    }

    IEnumerator Respuesta(BichitosScript bichitos){

        yield return new WaitForSeconds(0.5f);
        //distancia entre jugador y bichos
        float distance = Vector3.Distance(transform.position, bichitos.transform.position);
        //volumen en función de distancia, si estoy dentro del trigger
       float volume =Mathf.Clamp01(1 - distance / maxDistance);
       bichitos.EnteredPlayerTrigger(transform,maxDistance);
        yield return new WaitForSeconds(2f);
        llamadaHecha = false;
        permitirLlamada = true;
        Debug.Log("Puedo pulsar otra vez");

    }
    
}

