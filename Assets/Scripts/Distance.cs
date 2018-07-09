using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 
 * https://answers.unity.com/questions/16107/calculate-the-distance-a-object-has-moved.html
 * 
 * */

public class Distance : MonoBehaviour {
    public GameObject player;
    float distance = 0;
    Vector3 lastKnownPosition;

    //Constructor:
    public Distance()
    {

    }

    // Use this for initialization
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
      //  Debug.Log("Distance: " + distance);
    }

    public float getDistanceWalked()
    {
        return distance;
    }
    //On ApplicationQuit
    void OnApplicationQuit()
    {
        Debug.Log("Application Distance Walked: " + distance);
    }
}
