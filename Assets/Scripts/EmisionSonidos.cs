using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EmisionSonidos : MonoBehaviour
{

public AudioClip playerCall;
private AudioSource playerAudioSource;

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

    void OnTriggerEnter(Collider col){

        BichitosScript bichitos = col.GetComponent<BichitosScript>();

        if(col.gameObject.CompareTag("Bicho") && playerAudioSource.isPlaying){
            bichitos.EnteredPlayerTrigger();
            Debug.Log("Gritan los bichoss");
        }
    } 

    void OnTriggerExit(Collider col){

         BichitosScript bichitos = col.GetComponent<BichitosScript>();

        if(col.gameObject.CompareTag("Bicho"))
        {
             bichitos.ExitedPlayerTrigger();
            Debug.Log("No Gritan los bichoss");
        }
    } 
}

