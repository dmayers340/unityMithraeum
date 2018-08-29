using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.IO;
using System;

public class ArduinoScent : MonoBehaviour
{
    //Port where the Arduino is connected
    public static string COMPort = "COM5";

    SerialPort connection = new SerialPort(COMPort, 9600); //This is on arduino COM Port and baud rate

    int buttonState = 0;

    // open the connection to the Serial Port, if the connection is open  print to the console 
    void Start()
    {
        connection.Open();
        connection.ReadTimeout = 1;
        if (connection.IsOpen)
        {
            Debug.Log("Serial Port Open");
        }
    }

    // try to connect to the arduino, print out the value it is sending
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

    //When the application ends, also close the port
    void OnApplicationQuit()
    {
        connection.Close();

        if (!connection.IsOpen)
        {
            Debug.Log("Connection is closed");
        }
    }
}

