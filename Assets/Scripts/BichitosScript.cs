using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BichitosScript : MonoBehaviour
{

    public AudioClip[] bichitosResponse;

    private AudioSource bichitosAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        bichitosAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
    
}
