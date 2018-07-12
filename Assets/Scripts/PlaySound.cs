﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Play sound when user enters certain zones script.
 * In a further rendition, the sound should actually be spatialized and placed on an audio source
 * i.e. the tauroctony or a 'god figure'
 * 1.) Attach Script to Zone
 * 2.) If player torch enters the zone, get the audio source and play
 * */

public class PlaySound : MonoBehaviour
{
    //making this public so multiple queues can be made as needed if extended
    public GameObject sounds;
    //REFERENCE to AudioQueue script
    AudioQueue audioQueue; 
    //boolean to let know if user has entered the zone before
    bool hasEntered = false;

    //Get audioQueue script from sound
    void Start()
    {
        audioQueue = sounds.GetComponent<AudioQueue>();
    }

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
            audioQueue.AddAudioSourceToList(audio);
           // if(!audio.isPlaying)
           //{
           //  audio.Play();
           //}
        }
    }

}
