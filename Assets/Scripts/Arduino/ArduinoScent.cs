using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.IO.Ports;
//using System.IO;
using System;


//https://medium.com/@yifeiyin/communication-between-arduino-and-unity-9fdcccc2be3f
public class ArduinoScent : MonoBehaviour
{
    /*
    public static string COMPort = "COM5";

    SerialPort connection = new SerialPort(COMPort, 9600); //This is on arduino COM Port and baud rate

    int buttonState = 0;

    // Use this for initialization
    void Start()
    {
        connection.Open();
        connection.ReadTimeout = 1;
        if (connection.IsOpen)
        {
            Debug.Log("Serial Port Open");
        }
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            print(connection.ReadLine());
        }
        catch(System.Exception d)
        {
            
        }

        
        string value = connection.ReadLine();
        buttonState = int.Parse(value);
   
    
    }

    void printOut()
    {
        string connectedString = "Connected + " + buttonState;
        Debug.Log(connectedString);
    }

    void OnApplicationQuit()
    {
        connection.Close();

        if (!connection.IsOpen)
        {
            Debug.Log("Connection is closed");
        }
    }
    **/
}

