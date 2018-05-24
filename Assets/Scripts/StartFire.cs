/* 
 * Attach this script to all the torches. It will be used to start the fire using OnCollision?/OnTrigger? See which is better
 * Start with the particle effect/light being off, get all the components
 * Turn the torches on when the player's torch collides with them
 * 1.) Must make sure each torch object has a collider
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFire : MonoBehaviour
{

    public GameObject torch;
    public ParticleSystem fireParticleSystem;
    bool lightOn;
    void Start()
    {
        lightOn = false; //Start with the light off
        fireParticleSystem = GetComponent<ParticleSystem>();  //get Particle System 
        torch = GetComponent<GameObject>();  //get Torch
       
    }

    /*
     * if player's torch hits this torch (that is not lit)
     * Turn on the fire
     * Set the light being on to true
     * */
    private void OnCollisionEnter(Collision collision) 
    {
        if (this.gameObject.tag == ("torch") && collision.gameObject.tag == ("Player") && lightOn == false)
        {
            var emission = fireParticleSystem.emission;
            emission.enabled = false;
            //start the particle system
            emission.enabled = true;
            fireParticleSystem.Play();
            lightOn = true;
        }
    }
}
