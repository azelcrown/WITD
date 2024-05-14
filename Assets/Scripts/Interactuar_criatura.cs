using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntarObjeto : MonoBehaviour
{
    public Transform objetivo; // El objeto al que quieres apuntar

    void Update()
    {
        Vector3 direccion = objetivo.position - transform.position;
        Quaternion rotacion = Quaternion.LookRotation(direccion);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotacion, Time.deltaTime);
    }
}