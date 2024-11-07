using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] Animator anim1;
    [SerializeField] AudioSource audio;

    public void Starts()
    {
        anim.enabled = true;
        anim1.Play("Vagonetka");
        audio.Play();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
