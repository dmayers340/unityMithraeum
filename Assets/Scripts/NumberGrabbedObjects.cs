using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

/*
 * Logging Script
 * Gets the Number of Objects the User has Interacted With
 *  
 * 1.) Attach to Game Management Object
 * 2.) Get the number of times the user grabs an object from VRTK script (modified)
 * */
public class NumberGrabbedObjects : MonoBehaviour
{

    private int countGrabbedObjects;

    //Empty Constructor, I would like to have this in a game management script and have all the 'log' scripts be inside of that, however, not currently working
    public NumberGrabbedObjects()
    {

    }

    //At start, set count to 0
	void Start ()
    {
        countGrabbedObjects = 0;
	}
	

    void OnApplicationQuit ()
    {
        Debug.Log("Count of Grabbed Objects " + countGrabbedObjects);	
    }

    //Accessor to get the count 
    public int getGrabbedObjects()
    {
        return countGrabbedObjects;
    }
}
