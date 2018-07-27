using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayersCOntrl : MonoBehaviour
{
    AudioSource zoneAudio;
    bool hasEnteredZone = false;
  
    Collider[] colliders;

    public GameObject parent;


    private void Start()
    {
        //get the audio from the zone and the zone's collider
        zoneAudio = GetComponent<AudioSource>();

        colliders = parent.GetComponentsInChildren<Collider>();
        foreach (Collider col in colliders)
        {
            col.enabled = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        //if enter zone and have not entered it before
        if (other.CompareTag("playertorch"))
        {

            //if no audio is playing, play that audio and mark the zone as having been entered
            if (!zoneAudio.isPlaying && hasEnteredZone == false)
            {
                hasEnteredZone = true;
                zoneAudio.Play();
                if (zoneAudio.isPlaying)
                {
                    foreach (Collider col in colliders)
                    {
                        col.enabled = true;
                    }

                }
                else
                {
                    foreach (Collider col in colliders)
                    {
                        col.enabled = false;
                    }
                }

            }
        }
    }

}
