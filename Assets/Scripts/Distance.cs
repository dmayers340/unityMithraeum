using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script looks at how far the person has moved, however, not necessarily accurate due to tracking of headset rather than feet.
 * 1.) Attach this script to Game Management Object
 * 2.) Get the Player (using the OVRCamera)
 * https://answers.unity.com/questions/16107/calculate-the-distance-a-object-has-moved.html
 * 
 * */

public class Distance : MonoBehaviour {
    public GameObject player;
    float distance = 0;
    Vector3 lastKnownPosition;

    //Constructor, I would like to have this in a game management script and have all the 'log' scripts be inside of that, however, not currently working
    public Distance()
    {

    }

    //Set the position to transform of the camera
    void Start ()
    {
        lastKnownPosition = player.transform.position;
    }

    //https://docs.unity3d.com/ScriptReference/Vector3.html
    //Get the distance by calculating distance on vector from last position to current position
    void Update ()
    {
        distance = distance + Vector3.Distance(player.transform.position, lastKnownPosition);
        lastKnownPosition = player.transform.position; //Reset lastKnownPosition to current position	
    }

    public float getDistanceWalked()
    {
        return distance;
    }
    //On ApplicationQuit Have it Print out the Distance
    void OnApplicationQuit()
    {
        Debug.Log("Application Distance Walked: " + distance);
    }
}
