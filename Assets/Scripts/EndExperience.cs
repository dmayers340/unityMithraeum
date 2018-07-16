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
    AudioSource audioSource;

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
    ParticleSystem psNine;
    
    //Get all the Particle Systems
	void Start ()
    {
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
	
    //Play the audio source to end the experience
    public void PlayAudio()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

	// Update is called once per frame
	public void StopLights ()
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
