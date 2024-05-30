using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
    public class AmbientZone : MonoBehaviour
    {
        
        public CinemachinePathBase m_Path;
        
        public GameObject Player;

        float m_Position;       // The position along the path to set the cart to in path units
        private CinemachinePathBase.PositionUnits m_PositionUnits = CinemachinePathBase.PositionUnits.PathUnits;

        void Update()
        {   
            SetCartPosition(m_Path.FindClosestPoint(Player.transform.position, 0, -1, 10));
           
            Vector3 Sub = transform.position - Player.transform.position;
            Vector3 Spline = transform.right;
            
            if(Vector3.Dot(Sub, Spline) > 0)
            {
                transform.position = Player.transform.position;
                transform.rotation = Player.transform.rotation;
            }   
        }

        
        void SetCartPosition(float distanceAlongPath)
        {
            m_Position = m_Path.StandardizeUnit(distanceAlongPath, m_PositionUnits);
            transform.position = m_Path.EvaluatePositionAtUnit(m_Position, m_PositionUnits);
            transform.rotation = m_Path.EvaluateOrientationAtUnit(m_Position, m_PositionUnits);
        }
    }
}