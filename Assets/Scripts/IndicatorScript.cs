using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorScript : MonoBehaviour
{
    public Transform target; // El objeto al que quieres apuntar
    private RectTransform pointerRectTransform; // Referencia al rectángulo de transformación del indicador

    private void Awake()
    {
        pointerRectTransform = transform.GetComponent<RectTransform>();
    }

    private void Update()
    {
        Vector3 toPosition = target.position;
        Vector3 fromPosition = Camera.main.transform.position;
        fromPosition.z = 0f;
        Vector3 dir = (toPosition - fromPosition).normalized;
        float angle = UtilsClass.GetAngleFromVectorFloat(dir);
        pointerRectTransform.localEulerAngles = new Vector3(0, 0, angle);
    }
}