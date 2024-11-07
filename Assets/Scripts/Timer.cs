using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text textx;
    private float timer;
    public bool flag = false;
    private void Update()
    {
        if (flag)
        {
            timer += 1 * Time.deltaTime;
            textx.text = timer.ToString();
        }
    }

    public void isTrueFlag()
    {
        flag = true;
    }

}
