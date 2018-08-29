using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Working on using arrays to make the code cleaner, however, currently the colliders will not turn off after 
 * the audio plays and therefore is not implemented
 * */
public class TestPlayersCOntrl : MonoBehaviour
{
    AudioSource zoneAudio;
    bool hasEnteredZone = false;
    bool collidersAreOn = false;

    private Collider[] colliders;

    public GameObject boundaryObj1;
    public GameObject boundaryObj2;
    public GameObject boundaryObj3;
    public GameObject boundaryObj4;

    GameObject[] boundaries = new GameObject[4];

    private void Start()
    {
        boundaries[0] = boundaryObj1;
        boundaries[1] = boundaryObj2;
        boundaries[2] = boundaryObj3;
        boundaries[3] = boundaryObj4;

        //get the audio from the zone and the zone's collider
        zoneAudio = GetComponent<AudioSource>();

        for(int i = 0; i<boundaries.Length; i++)
        {
            colliders[i] = boundaries[i].GetComponent<Collider>();

            foreach(Collider col in colliders)
            {
                col.enabled = false;
            }
        }

    }

    private void Update()
    {
        if (!zoneAudio.isPlaying && collidersAreOn)
        {
            foreach(Collider col in colliders)
            {
                col.enabled = false;
            }
            collidersAreOn = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //if enter zone and have not entered it before
        if (other.CompareTag("playertorch") && hasEnteredZone == false)
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
