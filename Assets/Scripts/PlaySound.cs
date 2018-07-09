using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Play sound when user enters certain zones script.
 * 
 * 1.) Attach Script to Zone
 * 2.) If player torch enters the zone, get the audio source and play
 * */
public class PlaySound : MonoBehaviour
{
    //boolean to let know if user has entered the zone before
    bool hasEntered = false;

    //Use on Trigger. Play torch has the rigid body
    //Sound is attached to this zone object
    private void OnTriggerEnter(Collider other)
    {
        //if the thing entering the zone is the player's torch and they have not entered before
        //then make the boolean true, get the audio source and if it is not playing, play the audio
        if(other.CompareTag("playertorch") && hasEntered == false)
        {
            hasEntered = true;
            Debug.Log("Entered Zone");

            AudioSource audio = GetComponent<AudioSource>();
            if(!audio.isPlaying)
            {
                audio.Play();
            }
        }
    }

}
