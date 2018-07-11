using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.IO;
using System;

//https://medium.com/@yifeiyin/communication-between-arduino-and-unity-9fdcccc2be3f
public class ArduinoScent : MonoBehaviour
{
    public static string COMPort = "COM5";
    SerialPort stream = new SerialPort(COMPort, 9600); //This is on arduino COM Port and baud rate

    int buttonState = 0;

    // Use this for initialization
    void Start()
    {
        stream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        string value = stream.ReadLine();
        buttonState = int.Parse(value);
    }

    void printOut()
    {
        string connectedString = "Connected + " + buttonState;
        Debug.Log(connectedString);
    }

}

