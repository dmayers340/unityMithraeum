using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

/*
 * Game Management to attach to GameManagement Object
 * This will keep track off all the logging scripts and get the distance, time, gaze, and objects grabbed
 * at the end of the experience
 * */
public class GameManagement : MonoBehaviour
{
    LogTime timeScript;
    Distance distanceScript;
    NumberGrabbedObjects grabbedScript;
    public GameObject gameManagement;
    
    void Start()
    {
        gameManagement = GameObject.Find("management");

        timeScript = gameManagement.AddComponent<LogTime>(); 
        distanceScript = gameManagement.AddComponent<Distance>();
        grabbedScript = gameManagement.AddComponent<NumberGrabbedObjects>();
    }

    void OnApplicationQuit()
    {
        Debug.Log("Count of Grabbed Objects " + grabbedScript.getGrabbedObjects());
        Debug.Log("Application Distance Walked: " + distanceScript.getDistanceWalked());
        Debug.Log("Time Spent: " + timeScript.getTimeSpent());
    }
   
}
