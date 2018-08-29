using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * After many problems with the audio queue, it was decided to instead make a player controller which would enable colliders to keep the player in a specified area of the experience
 * until the god voice is done talking  (like a video game tutorial).
 * 
 * This script is attached to the sound zone
 * 
 * When the player enters a sound zone (rather, the torch which is a rigid body) and they have not entered it before, the audio will play
 * The player will be restricted  to the zone until audio finishes playing by enabling four colliders to make a box
 * Once the audio finishes playing, then the colliders will be disabled and the player can continue
 * 
 * @see TestPlayerControl.cs 
 * I have tried to tidy up this script using an array of colliders inside the TestPlayerControl script, but ended up using this script as the TestPlayerControl did not work
 * */
public class PlayerController : MonoBehaviour
{
    AudioSource zoneAudio; //audio source from the sound zone.

    bool hasEnteredZone = false; //checks if the player has entered the zone before,

    //The four game objects that hold the collider to turn on
    public GameObject boundaryObj1;
    public GameObject boundaryObj2;
    public GameObject boundaryObj3;
    public GameObject boundaryObj4;

    //Collider that is on each object. 
    Collider boundaryCollider1;
    Collider boundaryCollider2;
    Collider boundaryCollider3;
    Collider boundaryCollider4;

    bool collidersAreOn = false; //checks if the state of the colliders

    /**
     * The start function gets all of the componenets needed
     * 1.) The audio source from sound zone
     * 2.) The colliders on each boundary object
     * */
    private void Start()
    {
        {
            //get the audio from the zone and the zone's collider
            zoneAudio = GetComponent<AudioSource>();

            //Get the colliders, and make sure their colliders are disabled to start
            boundaryCollider1 = boundaryObj1.GetComponent<Collider>();
            boundaryCollider1.enabled = false;

            boundaryCollider2 = boundaryObj2.GetComponent<Collider>();
            boundaryCollider2.enabled = false;

            boundaryCollider3 = boundaryObj3.GetComponent<Collider>();
            boundaryCollider3.enabled = false;

            boundaryCollider4 = boundaryObj4.GetComponent<Collider>();
            boundaryCollider4.enabled = false;

        }
    }

    /**
     * This calls once a frame. If the audio is not playing and the colliders are on,
     * the colliders should be turned off
     * */
    private void Update()
    {
        if (!zoneAudio.isPlaying && collidersAreOn)
        {
            boundaryCollider1.enabled = false;
            boundaryCollider2.enabled = false;
            boundaryCollider3.enabled = false;
            boundaryCollider4.enabled = false;
            collidersAreOn = false;
        }
    }

    /**
     * Once the user enters the zone, and has not entered it before
     * Set has entered to true
     * Play the audio
     * turn on colliders while audio is playing
     * */ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("playertorch") && hasEnteredZone == false)
        {           
            hasEnteredZone = true;
            zoneAudio.Play();
            //if audio is playing, keep player enclosed in that area by turning on the colliders
            if (zoneAudio.isPlaying)
            {
                boundaryCollider1.enabled = true;
                boundaryCollider2.enabled = true;
                boundaryCollider3.enabled = true;
                boundaryCollider4.enabled = true;
                collidersAreOn = true;
            }    
        }
    }

}