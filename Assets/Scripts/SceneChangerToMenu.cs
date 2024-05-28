using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangerToMenu : MonoBehaviour
{
    // Nombre de la escena a la que deseas cambiar
    public string Menú = "";
    
    // Tecla que se usará para cambiar de escena
   // private KeyCodechangeKey = ke;

    //public KeyCodeChangeKey {get=>i;set=>i=value;}


    void Update()
    {
        // Verifica si se presiona la tecla especificada
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Cambia a la escena especificada
            SceneManager.LoadScene("Menú");
        }
    }
}
