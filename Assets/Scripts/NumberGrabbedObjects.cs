using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGrabbedObjects : MonoBehaviour {

    int countGrabbedObjects;

    //Empty Constructor
    public NumberGrabbedObjects()
    {

    }

	// Use this for initialization
	void Start ()
    {
        countGrabbedObjects = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log("Count of Grabbed Objects " + countGrabbedObjects);	
	}

    public int getGrabbedObjects()
    {
        return countGrabbedObjects;
    }
    void OnApplicationQuit ()
    {
        Debug.Log("Count of Grabbed Objects " + countGrabbedObjects);	
    }
}
