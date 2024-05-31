using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour

{
    public static GameManager Instance ;
    public bool tengo_guardapelo;
    public bool tengo_anillo;
    public bool tengo_huevos;
    public bool tengo_nido;
    public bool tengo_carta;
    public bool tengo_abrecartas;
    // Start is called before the first frame update
    void Awake ()
    {
        if (Instance != null && Instance != this){
            Destroy(this.gameObject); 
        } else {
            Instance = this; DontDestroyOnLoad(this.gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
