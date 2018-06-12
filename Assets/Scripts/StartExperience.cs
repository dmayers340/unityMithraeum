using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Start of the experience.
 * 1.) Start with directional light off
 * 2.) Play sound clip 
 * 3.) When sound ends turn on torch light OR SHOULD I DO start new scene?
 * */
public class StartExperience : MonoBehaviour
{
   public AudioSource audioSource;
   public GameObject torch;
   ParticleSystem ps;

    // Use this for initialization
    void Start ()
    {
        ps = torch.GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    // Update is called once per frame
    void Update ()
    {
        if (!audioSource.isPlaying)
        {
            Debug.Log("Audio Stopped Play");
            
               
            //turn on the light
            ps.Play();
        }
	}
    
}
