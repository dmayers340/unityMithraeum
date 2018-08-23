using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script is attached to the interactable cubes in the Information/Tutorial Scene
 * When a cube is picked up, the sound clip will play to give more information
 * */

public class StartSoundOnPickUp : MonoBehaviour
{
    bool isGrabbed = false;

    public GameObject cube; 
    //Get the audio source from the cube to play
    public AudioSource audio; 

	// Use this for initialization
	void Start ()
    {
        audio = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //If the cube is grabbed AND audio is not playing, play audio
        if(isGrabbed &&  !audio.isPlaying)
        {
            audio.Play();          
        }
	}
}
