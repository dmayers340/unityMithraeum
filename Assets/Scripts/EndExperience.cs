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
    public AudioSource audioSource;

    public GameObject torchLeftOne;
    ParticleSystem psOne;

    public GameObject torchLeftTwo;
    ParticleSystem psTwo;

    public GameObject torchRightOne;
    ParticleSystem psThree;

    public GameObject torchRightTwo;
    ParticleSystem psFour;

    public GameObject playerTorch;
    ParticleSystem psFive;

    public GameObject apseTorchOne;
    ParticleSystem psSix;

    public GameObject apseTorchTwo;
    ParticleSystem psSeven;

    public GameObject doorTorchOne;
    ParticleSystem psEight;

    public GameObject doorTorchTwo;
    ParticleSystem psNine;

	// Use this for initialization
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

        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

    }
	
	// Update is called once per frame
	void Update ()
    {
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
}
