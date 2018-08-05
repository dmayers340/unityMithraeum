using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * End of the experience
 * 1.) All lights in scene are turned on
 * 2.) Play sound clip 
 * 3.) When sound ends, turn off lights
 * */
public class EndExperience : MonoBehaviour
{
    AudioSource audioSource; //end of game clip

    GameObject audio;

    //Get All the Torches and their Particle Systems
    public GameObject torchLeftOne;
    ParticleSystem psOne;

    //Torch 2
    public GameObject torchLeftTwo;
    ParticleSystem psTwo;

    //Torch3
    public GameObject torchRightOne;
    ParticleSystem psThree;

    //Torch4
    public GameObject torchRightTwo;
    ParticleSystem psFour;

    //Torch5
    public GameObject playerTorch;
    ParticleSystem psFive;

    //Torch Six
    public GameObject apseTorchOne;
    ParticleSystem psSix;

    //Torch Seven
    public GameObject apseTorchTwo;
    ParticleSystem psSeven;

    //Torch Eight
    public GameObject doorTorchOne;
    ParticleSystem psEight;

    //Torch Nine
    public GameObject doorTorchTwo;

    internal void PlayAudio()
    {
        throw new NotImplementedException();
    }

    ParticleSystem psNine;
    
    //Get all the Particle Systems
	void Start ()
    {
        audioSource = audio.GetComponent<AudioSource>();

        psOne = torchLeftOne.GetComponent<ParticleSystem>();
        psTwo = torchLeftTwo.GetComponent<ParticleSystem>();
        psThree = torchRightOne.GetComponent<ParticleSystem>();
        psFour = torchRightTwo.GetComponent<ParticleSystem>();
        psFive = playerTorch.GetComponent<ParticleSystem>();
        psSix = apseTorchOne.GetComponent<ParticleSystem>();
        psSeven = apseTorchTwo.GetComponent<ParticleSystem>();
        psEight = doorTorchOne.GetComponent<ParticleSystem>();
        psNine = doorTorchTwo.GetComponent<ParticleSystem>();
    }


    public void EndGame()
    {
        if(Input.GetMouseButtonDown(0))
        {
            audioSource.Play();

            if (!audioSource.isPlaying)
            {
                psOne.Stop();
                psTwo.Stop();
                psThree.Stop();
                psFour.Stop();
                psFive.Stop();
                psSix.Stop();
                psSeven.Stop();
                psEight.Stop();
                psNine.Stop();
            }
        }
        else if(Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

}
