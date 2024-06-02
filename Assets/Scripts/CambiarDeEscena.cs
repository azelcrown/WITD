using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
using UnityEngine.SceneManagement;

public class CambiarDeEscena : MonoBehaviour
{
    public bool pasarNivel;
    public int indiceNivel;
    // Start is called before the first frame update
    void Start()
    {
         Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {

        //CAmbiar de nivel siempre que no estemos en el menú
        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().buildIndex != 0)
        {
            //ir al menu
            CambiarNivel(0);
        }


        if (pasarNivel)
        {
            CambiarNivel(indiceNivel);
        }
    }
    public void CambiarNivel(int indice)
    {
        SceneManager.LoadScene(indice);
    }

    public void IrAPlayMode(){
        SceneManager.LoadScene(1);
    }

    public void IrATesoros(){
        Debug.Log("Tesoros");
        SceneManager.LoadScene(2);
    }

}
