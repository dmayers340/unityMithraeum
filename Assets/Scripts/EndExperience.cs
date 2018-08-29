using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * End of the experience
 * 1.) All lights in scene are turned on
 * 2.) Play sound clip 
 * 3.) When sound ends, turn off lights
 * 
 * 
 * This was never implemented, but it would have been a nice way to end the experience.
 * */
public class EndExperience : MonoBehaviour
{
    AudioSource audioSource; //end of game clip
    AudioSource audioSourceChanting; //chanting clip
    bool hasPlayed = false;

    GameObject audio; //Game object audio source is on (In scene, this will be the Tauroctony to have spatialized audio)
    GameObject chantingAudio; //Game object to be outside of the temple to start

    //Get All the Torches and their Particle Systems
    public GameObject torchLeftOne;
    //Torch 2
    public GameObject torchLeftTwo;
    //Torch3
    public GameObject torchRightOne;
    //Torch4
    public GameObject torchRightTwo;
    //Torch5
    public GameObject playerTorch;
    //Torch Six
    public GameObject apseTorchOne;
    //Torch Seven
    public GameObject apseTorchTwo;
    //Torch Eight
    public GameObject doorTorchOne;
    //Torch Nine
    public GameObject doorTorchTwo;

    //Array to hold all the torches
    GameObject[] torchArray;

    /*
     *   Get the audio source
     *   Set up the torchArray
     *   Get all the Particle Systems from each torch in the array
     *  */
    void Start ()
    {
        audioSource = audio.GetComponent<AudioSource>();
        audioSourceChanting = chantingAudio.GetComponent<AudioSource>();

        torchArray = new GameObject[] { torchLeftOne, torchLeftTwo, torchRightOne, torchRightTwo, apseTorchOne, apseTorchTwo, playerTorch, doorTorchOne, doorTorchTwo};
        foreach(GameObject current in torchArray)
        {
            current.GetComponent<ParticleSystem>();
        }
    }

    /**
     * Ideally, this should be implemented once the user has lit all 8 torches, and a minute has gone by (for exploration time)
     * However, if the mouse is pressed, the audio will play the chanting to signal the ceremony is about to begin, and once the chanting ends the god will say 'goodbye'
     * This will then turn off all the particle systems-Once the experience is dark, it will signal the user to quit.
     * */
    public void EndGame()
    {
        if(Input.GetMouseButtonDown(0))
        {
            audioSourceChanting.Play();
       
            if (!audioSourceChanting.isPlaying && hasPlayed == false)
            {
                hasPlayed = true;
                audioSource.Play();
                foreach(GameObject current in torchArray)
                {
                    current.GetComponent<ParticleSystem>().Stop();
                }
            }
        }
        else if(Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

}
