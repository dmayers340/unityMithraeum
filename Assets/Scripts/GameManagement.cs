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
    /*
    LogTime timeScript;
    Distance distanceScript;
    NumberGrabbedObjects grabbedScript;
    VRTK_InteractableObject countObject;

	// Use this for initialization
    /*
	void Start ()
    {
        timeScript = this.AddComponent(Type.GetType("LogTime"));
        distanceScript = this.AddComponenet(Type.GetType("Distance"));
        grabbedScript = this.AddComponent<NumberGrabbedObjects>();
        countObject = this.AddComponent<VRTK_InteractableObject>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnApplicationQuit()
    {
        Debug.Log("Count of Grabbed Objects " + grabbedScript.getGrabbedObjects());
        Debug.Log("Application Distance Walked: " + distanceScript.getDistanceWalked());
        Debug.Log("Time Spent: " + timeScript.getTimeSpent());
        Debug.Log("VRTK count object " + countObject.getCountOfObjectsGrabbed());
    }
    */
}
