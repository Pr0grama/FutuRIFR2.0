using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Trassa : MonoBehaviour
{
    private CinemachineDollyCart p;
    [SerializeField] private GameObject cnvs;
    [SerializeField] AudioSource audio2;
    private void Start()
    {
        p = GetComponent<CinemachineDollyCart>();
    }
    void Update()
    {
        if (p.m_Position >= 826.0)
        {
            cnvs.SetActive(true);
            audio2.Stop();

        }
    }

    public void Restart()
    {
        p.m_Position = 0;
    }
}
