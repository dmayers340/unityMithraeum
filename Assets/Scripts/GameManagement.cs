using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using System.IO;

/*
 * Game Management to attach to GameManagement Object
 * This will keep track off all the logging scripts and get the distance, time, gaze, and objects grabbed
 * at the end of the experience
 * */
public class GameManagement : MonoBehaviour
{
    //Get all the scripts
    LogTime timeScript;
    Distance distanceScript;
    NumberGrabbedObjects grabbedScript;
    EndExperience endGame;
    NumberOfTorchesLit torchLit;

    public GameObject endGameObject;
    public GameObject gameManagement;
    private string outputFileName = "dataOutFile.txt";
    
    void Start()
    {
        timeScript = gameManagement.GetComponent<LogTime>(); 
        distanceScript = gameManagement.GetComponent<Distance>();
        grabbedScript = gameManagement.GetComponent<NumberGrabbedObjects>();
        endGame = endGameObject.GetComponent<EndExperience>();
        torchLit = gameManagement.GetComponent<NumberOfTorchesLit>();
    }

    void OnApplicationQuit()
    {
        WriteToFile("Number of objects grabbed: " + grabbedScript.getGrabbedObjects().ToString());
        WriteToFile("Distance walked: " + distanceScript.getDistanceWalked().ToString());
        WriteToFile("Time spent in experience: " + timeScript.getTimeSpent().ToString());
        WriteToFile("Number of torches lit: " + torchLit.GetNumberOfTorchesLit().ToString());
        
        Debug.Log("From Game Management Count of Grabbed Objects " + grabbedScript.getGrabbedObjects());
        Debug.Log("From Game Management Application Distance Walked: " + distanceScript.getDistanceWalked());
        Debug.Log("From Game Management Time Spent: " + timeScript.getTimeSpent());
        Debug.Log("From Game Management Torches Lit: " + torchLit.GetNumberOfTorchesLit());

    }


    void WriteToFile(string data)
    {
        StreamWriter writer = new StreamWriter(outputFileName, true);
        writer.WriteLine(data);
        writer.Close();
    }
}
