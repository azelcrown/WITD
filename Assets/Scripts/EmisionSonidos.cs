using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EmisionSonidos : MonoBehaviour
{

    public AudioClip playerCall;
    private AudioSource playerAudioSource;

    private bool llamadaHecha = false;

    // Start is called before the first frame update
    void Start()
    {
        playerAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)){
            playerAudioSource.PlayOneShot(playerCall);
        }
    }

    void OnTriggerStay(Collider col){

        Debug.Log(playerAudioSource.isPlaying);

        if(col.gameObject.CompareTag("Bicho") && playerAudioSource.isPlaying){
           
            
            if(llamadaHecha == false){
                StartCoroutine(Respuesta(col));
                llamadaHecha = true;
            }
            Debug.Log("Gritan los bichoss");
        }
    } 

    void OnTriggerExit(Collider col){

        if(col.gameObject.CompareTag("Bicho"))
        {   BichitosScript bichitos = col.GetComponent<BichitosScript>();
             bichitos.ExitedPlayerTrigger();
            Debug.Log("No Gritan los bichoss");
        }
    } 


    IEnumerator Respuesta(Collider col){

        yield return new WaitForSeconds(1.5f);
        BichitosScript bichitos = col.GetComponent<BichitosScript>();
        bichitos.EnteredPlayerTrigger();
        yield return new WaitForSeconds(3f);
        llamadaHecha = false;
        Debug.Log("Puedo pulsar otra vez");

    }
}

