using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangeToInspect : MonoBehaviour
{
    // Nombre de la escena a la que deseas cambiar
    public string INSPECTINVENTARIO = "";
    
    // Tecla que se usará para cambiar de escena
   // private KeyCodechangeKey = ke;

    //public KeyCodeChangeKey {get=>i;set=>i=value;}


    void Update()
    {
        // Verifica si se presiona la tecla especificada
        if (Input.GetKeyDown(KeyCode.I))
        {
            // Cambia a la escena especificada
            SceneManager.LoadScene("InspectInvertario");
        }
    }
}
