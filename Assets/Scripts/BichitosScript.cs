using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class BichitosScript : MonoBehaviour
{

    public AudioClip bichitosResponse;

    private AudioSource bichitosAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        bichitosAudioSource = GetComponent<AudioSource>();
    }

    public void RespondToPlayerSound(){
        
        bichitosAudioSource.PlayOneShot(bichitosResponse);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

  
    
}
