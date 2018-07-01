using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

//https://medium.com/@yifeiyin/communication-between-arduino-and-unity-9fdcccc2be3f
public class ArduinoScent : MonoBehaviour
{
    SerialPort stream = new SerialPort("/dev/", 9600); //This is on arduino and baud rate
    int buttonState = 0;

	// Use this for initialization
	void Start ()
    {
        stream.Open();
	}
	
	// Update is called once per frame
	void Update ()
    {
        string value = stream.ReadLine();
        buttonState = int.Parse(value);
	}

}
