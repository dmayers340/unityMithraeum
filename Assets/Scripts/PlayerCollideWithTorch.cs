using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Lighting torch script. 
 * 1. Attach Script to player's torch
 * 2. The particle system on torch to be lit should be tagged as 'torch'
 * 3. Also need to have a collider on bit that has particle system as trigger
 * Created after asking for help on StackOverflow: https://stackoverflow.com/questions/49733313/unity3d-having-player-light-torches-using-particlesystem-and-oncollisionenter
 * */

public class PlayerCollideWithTorch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //If player collides with torch
        if (other.CompareTag("torch")) 
        {
            //Get particle system
            ParticleSystem ps = other.GetComponent<ParticleSystem>();

            //Play particle system
            ps.Play();
        }
    }
}
