using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartExperience : MonoBehaviour
{
   public AudioSource audioSource;
   public GameObject torch;
    ParticleSystem ps;
    // Use this for initialization
    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        ps = torch.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update ()
    {
        if (!audioSource.isPlaying)
        {
            //turn on the light
            ps.Play();
        }
	}
}
