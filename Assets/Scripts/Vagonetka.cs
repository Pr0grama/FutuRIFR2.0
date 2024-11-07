using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Vagonetka : MonoBehaviour
{
    [SerializeField] CinemachineDollyCart p;
    float ageX, ageZ;
    private void Start()
    {
        ageX = 0f;
        ageZ = 0f;
    }
    void FixedUpdate()
    {
        if (p.m_Position != 0.0)
        {
            if (p.m_Position <= 63.0)
            {
                while (ageZ < 20.0f)
                {
                    ageZ += 0.0001f;
                    transform.Rotate(0.0f, 0.0f, ageZ);
                }
            }
        }
    }
}
