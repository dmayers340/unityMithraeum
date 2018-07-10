using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPlayerMovement : MonoBehaviour
{
    bool hasEntered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && hasEntered == false)
        {
            hasEntered = true;

            AudioSource audio = this.GetComponent<AudioSource>();

            if(!audio.isPlaying)
            {
                audio.Play();
            }
        }
    }


}
