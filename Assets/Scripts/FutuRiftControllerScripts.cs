using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Futurift;
using Futurift.DataSenders;
using Futurift.Options;

public class FutuRiftControllerScripts : MonoBehaviour
{
    private FutuRiftController _controller;

    [SerializeField] private string ipAddress = "127.0.0.1";
    [SerializeField] private int port = 6065;

    [SerializeField] private float initialPitch = 0.0f;
    [SerializeField] private float initialRoll = 0.0f;

    [SerializeField] private int interval = 100;

    private void Awake()
    {
        var udpOptions = new UdpOptions
        {
            ip = ipAddress,
            port = port
        };

        var futuRiftOptions = new FutuRiftOptions
        {
            interval = interval
        };

        _controller = new FutuRiftController(
            dataSender: new UdpPortSender(udpOptions),
            futuRiftOptions: futuRiftOptions)
        {
            Pitch = initialPitch,
            Roll = initialRoll
        };
    }

    private void OnEnable()
    {
        _controller.Start();
    }

    private void OnDisable()
    {
        if(_controller != null)
        {
            _controller.Stop();
        }
    }

    private void Update()
    {
        var rot = transform.eulerAngles;
        if (rot.x > 100)
        {
            rot.x -= 360;
        }
        else
        {
            rot.x = rot.x;
        }

        rot.z = rot.z > 100 ? rot.z - 300 : rot.z;

        _controller.Pitch = rot.z;
        _controller.Roll = rot.x;
    }
}
