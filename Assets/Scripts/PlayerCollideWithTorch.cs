using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollideWithTorch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("torch")) //if player collides with torch
        {
            //Get particle system
            ParticleSystem ps = other.GetComponent<ParticleSystem>();

            //play particle system
            ps.Play();
        }
    }

    /*
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("torch"))
        {
            ParticleSystem ps = other.GetComponent<ParticleSystem>();

            ps.Stop();
        }
    }
    */
}
