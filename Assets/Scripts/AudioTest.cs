using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip[] audioClips;
    bool hasEntered = false;

    private void OnTriggerEnter(Collider other)
    {
        //if the thing entering the zone is the player's torch and they have not entered before
        //then make the boolean true, get the audio source and if it is not playing, play the audio
        if (other.CompareTag("zone") && hasEntered == false)
        {
            hasEntered = true;
            Debug.Log("Entered Zone");
            for (int i = 0; i < audioClips.Length; i++)
            {
                if (!audio.isPlaying)
                {
                    audio.clip = audioClips[i];
                    audio.Play();
                }
            }
        }
    }

    IEnumerator playAudioClips()
    {
        yield return null;

        for (int i = 0; i<audioClips.Length; i++)
        {
            audio.clip = audioClips[i];
            audio.Play();

            while(audio.isPlaying)
            {
                yield return null;
            }
        }
    }
}
