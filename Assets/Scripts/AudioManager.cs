using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
public AudioClip fxMapa; 
public AudioClip fxBichorl; 
public AudioClip fxBichorlCute; 
public AudioClip fxBichorlEww; 
public AudioClip fxBichorlgogo; 
public AudioClip fxBichorltontopolla; 
public static AudioManager Instance;
public GameObject musicObj;
AudioSource _audioSource;
AudioSource audioMusic;

void Awake(){

    if(Instance != null && Instance != this){
        
        Destroy(this.gameObject);

    }else{
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    
}

    // Start is called before the first frame update
    void Start()
    {
         _audioSource = this.GetComponent<AudioSource>();

        audioMusic = musicObj.GetComponent<AudioSource>();
        audioMusic.clip = fxMapa;
        audioMusic.loop = true;
        audioMusic.volume = 0.2f;
        audioMusic.Play();
        
    }


    // Update is called once per frame
    void Update()
    {

    }
    //Metodo para hacer sonar clips de audio
    public void SonarClipUnaVez(AudioClip ac){
        _audioSource.PlayOneShot(ac);
    }
}
