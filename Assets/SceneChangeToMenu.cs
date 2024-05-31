using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
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
