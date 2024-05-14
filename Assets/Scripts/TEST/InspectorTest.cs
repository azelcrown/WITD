using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectorTest : MonoBehaviour
{

    #region Inspector 
    public float mouseSpeed = 10f;
    public float distanciaObjeto = 5f;
    #endregion
    RaycastHit hit;
    Transform cameraTransform;



    FirstPersonController fpc;
    GameObject fpcObject;
    GameObject inspectedObject;
    Transform originalTranform = null;
    Vector3 originalPosition;
    Quaternion originalRotation;

    bool modeInspector = false;



    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
        fpc = FindFirstObjectByType<FirstPersonController>();
        fpcObject = GameObject.Find("FirstPersonController");
    }

    // Update is called once per frame
    void Update()
    {

        //MODO INSPECTOR
        if(modeInspector){

            RotateObjectWithMouse(); // Rotar el objeto con el ratón

            if(Input.GetMouseButtonDown (0)){
                inspectedObject.transform.position = originalPosition;
                inspectedObject.transform.rotation = originalRotation;
                inspectedObject.GetComponent<Collider>().isTrigger = false;


                //fpc.cameraCanMove = true;
                modeInspector = false;

                Debug.Log("vuelta");
            }


        }else{

            //MODO NORMAL
            if ( Input.GetMouseButtonDown (0)){ 


                Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
		        RaycastHit hit;

                //rayo desde la cámara
                // if ( Physics.Raycast (cameraTransform.position, cameraTransform.forward,out hit, 100.0f)) {

                //rayo desde el click
                if ( Physics.Raycast ( ray, out hit, 100f)) {

                    Debug.DrawRay(cameraTransform.position, cameraTransform.forward * 100.0f, Color.blue);
                    
                    if(hit.transform.tag == "Inspectable"){
                        
                        //fpc.cameraCanMove = false;
                        modeInspector = true;
                        inspectedObject = hit.collider.gameObject;
                        inspectedObject.GetComponent<Collider>().isTrigger = true;

                        originalPosition = inspectedObject.transform.position;
                        originalRotation = inspectedObject.transform.rotation;

                        CenterObject(hit.collider.gameObject.transform, cameraTransform.position);
                    
                    }
                }
            }
        }


    }

    //METODO PARA ROTAR EL OBJETO
    void RotateObjectWithMouse()
    {
        float mouseX = Input.GetAxis("Mouse X"); // Obtener el movimiento horizontal del ratón
        float mouseY = Input.GetAxis("Mouse Y"); // Obtener el movimiento vertical del ratón

        inspectedObject.transform.rotation = 
            Quaternion.AngleAxis(mouseX * mouseSpeed, transform.up) *
            Quaternion.AngleAxis(mouseY * mouseSpeed, transform.right) *
            inspectedObject.transform.rotation;

    }

    //METODO PARA centrar el objeto
    void CenterObject(Transform objecto, Vector3 direction)
    {
     
        //La position es la posicion de la cámara, más algo hacia adelante... ese algo es una cantidad pública (distanciaObjeto) a la que le multiplico la magnitud del objeto para que los objetos graandes se hagan más pequeños
        Vector3 targetPosition = Camera.main.transform.position + Camera.main.transform.forward * (objecto.GetComponent<Collider>().bounds.size.magnitude/10 * distanciaObjeto);
        objecto.transform.position = targetPosition;
   
    }




}
