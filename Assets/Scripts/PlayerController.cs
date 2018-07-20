using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * After many problems with the audio queue, it was decided to instead make a player controller
 * This script is attached to the player torch (because it has a rigid body attached)
 * When the player enters a sound zone and they have not entered it before, the audio will play
 * The player will be restricted  to the zone until audio finishes playing
 * */
public class PlayerController : MonoBehaviour
{
    AudioSource zoneAudio;
    bool hasEnteredZone = false;
    Collider boundaryCollider;
    public GameObject boundaryObj;

    private void OnTriggerEnter(Collider other)
    {
        //if enter zone and have not entered it before
        if(other.CompareTag("playertorch"))
        {
            //get the audio from the zone and the zone's collider
            zoneAudio = GetComponent<AudioSource>();
            boundaryCollider = boundaryObj.GetComponent<Collider>();

            //if no audio is playing, play that audio and mark the zone as having been entered
            if(!zoneAudio.isPlaying && hasEnteredZone == false)
            {
                zoneAudio.Play();
                Debug.Log("played audio");
                hasEnteredZone = true;

                boundaryCollider.enabled = true;
            }
            //otherwise, this means audio is playing and need to restrict player access to the zone by turning on the boundary collider
            else 
            {
                boundaryCollider.enabled = false;
            }
        }
    }
}
