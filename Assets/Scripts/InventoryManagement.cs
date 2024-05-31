using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManagement : MonoBehaviour

{
    public GameObject guardapelo;
    public GameObject anillo;
    public GameObject huevos;
    public GameObject nido;
    public GameObject carta;
    public GameObject abrecartas;
    // Start is called before the first frame update
    void Start()
    {

//guardapelo
        if (GameManager.Instance.tengo_guardapelo == true)
        {
            guardapelo.SetActive(true);

        }
        else
        {
            guardapelo.SetActive(false);
        }

//anillo
         if (GameManager.Instance.tengo_anillo == true)
        {
            anillo.SetActive(true);

        }
        else
        {
            anillo.SetActive(false);
        }

//huevos
         if (GameManager.Instance.tengo_huevos == true)
        {
            huevos.SetActive(true);

        }
        else
        {
            huevos.SetActive(false);
        }

//nido
         if (GameManager.Instance.tengo_nido == true)
        {
            nido.SetActive(true);

        }
        else
        {
            nido.SetActive(false);
        }

//carta
         if (GameManager.Instance.tengo_carta == true)
        {
            carta.SetActive(true);

        }
        else
        {
            carta.SetActive(false);
        }

//abrecartas
         if (GameManager.Instance.tengo_abrecartas == true)
        {
            abrecartas.SetActive(true);

        }
        else
        {
            abrecartas.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
