using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Play sound when in certain zones script.
 * 1.) Attach Script to Player Torch
 * 2.) If in zone, get the audio source and play
 * 
 * */
public class PlaySound : MonoBehaviour
{
    bool hasEntered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("zone") && hasEntered == false)
        {
            hasEntered = true;
            Debug.Log("Entered Zone");

            AudioSource audio = other.GetComponent<AudioSource>();

            if(!audio.isPlaying)
            {
                audio.Play();
            }
        }
    }

}
