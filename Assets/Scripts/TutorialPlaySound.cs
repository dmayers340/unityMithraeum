using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPlaySound : MonoBehaviour {

    AudioSource audio;

	// Use this for initialization
	void Start ()
    {
        audio = GetComponent<AudioSource>();
	}
	
	void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audio.Play();
        }
    }
}
