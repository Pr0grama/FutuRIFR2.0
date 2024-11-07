using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] Animator anim;

    public void Starts()
    {
        anim.enabled = true;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
