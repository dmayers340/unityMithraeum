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

    GameObject[] torchArray; 

    internal void PlayAudio()
    {
        throw new NotImplementedException();
    }
    
    //Get all the Particle Systems
	void Start ()
    {
        GameObject[] torchArray = new GameObject[] { torchLeftOne, torchLeftTwo, torchRightOne, torchRightTwo, apseTorchOne, apseTorchTwo, playerTorch, doorTorchOne, doorTorchTwo };
        foreach(GameObject current in torchArray)
        {
            current.GetComponent<ParticleSystem>();
        }

        audioSource = audio.GetComponent<AudioSource>();

    }


    public void EndGame()
    {
        if(Input.GetMouseButtonDown(0))
        {
            audioSource.Play();

            if (!audioSource.isPlaying)
            {
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
