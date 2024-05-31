using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_Inventario : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
  
    void OnMouseDown () {
Debug.Log("Click botón izquierdo sobre el objecto  con colisión");

    }


    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0)){
        Debug.Log("Click izq en cualquier parte");
       } 
    }
}
