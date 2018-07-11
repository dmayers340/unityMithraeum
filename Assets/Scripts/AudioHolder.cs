using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Keep a queue of audio files to play when called
 * If user enters a Sound Zone, the audio should be placed in the audioSourceList to be played once the previous 
 * audio source finishes playing
 * */

public class AudioHolder : MonoBehaviour
{
    public List<AudioSource> audioSourceArrayList; //List of audio files, can grow as needed
    int index = 0; //index of array
    AudioSource currentAudioSource; //current audio source
    bool hasAudio;

    void Start()
    {
        audioSourceArrayList = new List<AudioSource>();
        currentAudioSource = audioSourceArrayList[index];

        if (audioSourceArrayList.Count > 0)
        {
            AudioPlay();
          //  StartCoroutine(PlayAudio()); //Always play some audio...Not sure this is what I want
        }
    }

    public void AudioPlay()
    {
        if(!currentAudioSource.isPlaying)
        {
            currentAudioSource = audioSourceArrayList[index];
            currentAudioSource.Play();
            index++;
        }
    }

    public void AddAudioSourceToList(AudioSource audioSource)
    {
        if(audioSource != null)
        {
            audioSourceArrayList.Add(audioSource);
        }
    }

    /*
    IEnumerator PlayAudio()
    {
        while(true)
        {
            //if the current audio source is not playing
            if(!currentAudioSource.isPlaying)
            {
                //play the current audio source
                currentAudioSource = audioSourceArrayList[index];
                currentAudioSource.Play();
                index++; //increase the index
            }
        }
    }
    */
	
}
