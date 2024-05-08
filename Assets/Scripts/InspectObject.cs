using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class InspectObject : MonoBehaviour
{
    private Camera _camera;

    private Transform _inspectObjectTransform;

    public float deltaRotationX;
    public float deltaRotationY;
    public float rotateSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit RayHit;

            if (CameraToMouseRay(Input.mousePosition, out RayHit))
            {
                if(RayHit.transform.gameObject.tag == "Inspectable")
                _inspectObjectTransform = RayHit.transform;
            }

        }
        
        deltaRotationX = -Input.GetAxis("Mouse X");
        deltaRotationY = Input.GetAxis ("Mouse Y");

        if(Input.GetMouseButton(1) && _inspectObjectTransform)
        {
            _inspectObjectTransform.rotation = 
                Quaternion.AngleAxis(deltaRotationX * rotateSpeed, transform.up) * //Rota eje X
                Quaternion.AngleAxis(deltaRotationY * rotateSpeed, transform.right) * //Rota eje Y
                _inspectObjectTransform.rotation; //Tiene en cuenta la rotación existente

        }
    }
    private bool CameraToMouseRay(Vector2 mousePosition, out RaycastHit RayHit)
    {
        Ray ray = _camera.ScreenPointToRay(mousePosition);
        
        return Physics.Raycast(ray, out RayHit);
    }
}
