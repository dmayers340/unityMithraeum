using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Lighting torch script. 
 * 1.) Attach Script to player's torch
 * 2.) The particle system on torch to be lit should be tagged as 'torch'
 * 3.) Also need to have a collider on bit that has particle system as trigger
 * Created after asking for help on StackOverflow: https://stackoverflow.com/questions/49733313/unity3d-having-player-light-torches-using-particlesystem-and-oncollisionenter
 * 
 * Changes during the summer PROJECT, working on number torches lit and also added sound play
 * */

public class PlayerCollideWithTorch : MonoBehaviour
{
    int numTorchesLit;
    bool torchLit = false;

    private void Start()
    {
        numTorchesLit = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        //If player collides with torch
        if (other.CompareTag("torch") && torchLit == false) 
        {
            //Get particle system
            ParticleSystem ps = other.GetComponent<ParticleSystem>();

            //Play particle system and audio on light
            ps.Play();
            torchLit = true;
            numTorchesLit += 1;

            AudioSource audio = other.GetComponent<AudioSource>();
            audio.Play();
          
        }
    }

    public int getNumTorchesLit()
    {
        return numTorchesLit;
    }
}
