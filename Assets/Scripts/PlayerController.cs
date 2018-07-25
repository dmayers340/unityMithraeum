using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * After many problems with the audio queue, it was decided to instead make a player controller
 * This script is attached to the sound zone
 * When the player enters a sound zone (rather, the torch which is a rigid body) and they have not entered it before, the audio will play
 * The player will be restricted  to the zone until audio finishes playing by enabling four colliders to make a box
 * Once the audio finishes playing, then the colliders will be disabled and the player can continue
 * */
public class PlayerController : MonoBehaviour
{
    AudioSource zoneAudio;
    bool hasEnteredZone = false;
    Collider boundaryCollider1;
    Collider boundaryCollider2;
    Collider boundaryCollider3;
    Collider boundaryCollider4;


    public GameObject boundaryObj1;
    public GameObject boundaryObj2;
    public GameObject boundaryObj3;
    public GameObject boundaryObj4;

    private void Start()
    {
        {
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
    private void OnTriggerEnter(Collider other)
    {
        //if enter zone and have not entered it before
        if(other.CompareTag("playertorch"))
        {
            //get the audio from the zone and the zone's collider
            zoneAudio = GetComponent<AudioSource>();
            //if no audio is playing, play that audio and mark the zone as having been entered
            if(!zoneAudio.isPlaying && hasEnteredZone == false)
            {
                hasEnteredZone = true;
                zoneAudio.Play();
                boundaryCollider1.enabled = true;
                boundaryCollider2.enabled = true;
                boundaryCollider3.enabled = true;
                boundaryCollider4.enabled = true;

                if(zoneAudio.isPlaying == false)
                {
                    boundaryCollider1.enabled = false;
                    boundaryCollider2.enabled = false;
                    boundaryCollider3.enabled = false;
                    boundaryCollider4.enabled = false;
                }
                
        
            }

        }
    }
}
