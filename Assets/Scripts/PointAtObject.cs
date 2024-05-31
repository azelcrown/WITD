using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAtObject : MonoBehaviour
{
    public List<Transform> targetObjects; // Referencia a los objetos a los que la flecha puede apuntar

    // Actualiza la rotación de la flecha cada frame
    void Update()
    {
        Transform closestTarget = null;
        float closestDistance = Mathf.Infinity;

        // Busca el objeto más cercano
        foreach (Transform target in targetObjects)
        {
            // Verifica si el objeto objetivo es nulo antes de intentar acceder a su posición
            if (target != null)
            {
                float distanceToTarget = Vector3.Distance(transform.position, target.position);
                if (distanceToTarget < closestDistance)
                {
                    closestDistance = distanceToTarget;
                    closestTarget = target;
                }
            }
        }

        // Si hay un objeto más cercano, apunta hacia él
        if (closestTarget != null)
        {
            Vector3 directionToTarget = closestTarget.position - transform.position; // Calcula la dirección al objeto objetivo
            Quaternion targetRotation = Quaternion.LookRotation(directionToTarget); // Calcula la rotación necesaria para que la flecha apunte al objeto objetivo

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime); // Suaviza la rotación de la flecha hacia la rotación objetivo
        }
    }
}