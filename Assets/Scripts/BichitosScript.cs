using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BichitosScript : MonoBehaviour
{
    GameObject fpc;
    public AudioClip bichitosResponse;

    private AudioSource _audioSource;


    // Start is called before the first frame update
    void Start()
    {   
        fpc = GameObject.Find("FirstPersonController");
        _audioSource = GetComponent<AudioSource>();
    }

    
    public void EnteredPlayerTrigger(){
        _audioSource.PlayOneShot(bichitosResponse);
        
    }

    public void ExitedPlayerTrigger(){
       _audioSource.Stop();
    }

    // Update is called once per frame

    void Update()
    {

       
        
    }

  
    
}
