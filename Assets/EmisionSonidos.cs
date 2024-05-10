using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EmisionSonidos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){

        if(col.gameObject.tag == "Bicho"){
            Debug.Log("Gritan los bichoss");
        }
    } 

    void OnTriggerExit(Collider col){

        if(col.gameObject.tag == "Bicho"){
            Debug.Log("No Gritan los bichoss");
        }
    } 
}

