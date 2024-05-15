using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BichitosScript : MonoBehaviour
{
   
    public AudioClip bichitosResponse;

    private AudioSource _audioSource;



    // Start is called before the first frame update
    void Start()
    {   

        _audioSource = GetComponent<AudioSource>();
    }

     public void PlayResponseSound(float volume){

        _audioSource.volume = volume;
        _audioSource.PlayOneShot(bichitosResponse);
    }
    public void EnteredPlayerTrigger(Transform playerTransform, float maxDistance){
        float distance = Vector3.Distance(transform.position, playerTransform.position);
        float volume = Mathf.Clamp01(1 - distance / maxDistance);
        PlayResponseSound(volume);
        
    }

    public void ExitedPlayerTrigger(){
       _audioSource.Stop();
    }

    // Update is called once per frame

    void Update()
    {

       
        
    }

  
    
}
