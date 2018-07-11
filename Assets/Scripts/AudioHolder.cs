using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Keep a queue of audio files to play when called
 * If user enters a Sound Zone, the audio should be placed in the audioSourceList to be played once the previous 
 * audio source finishes playing
 * 
 * Play the first audio clip that is queued as needed
 * */
public class AudioHolder : MonoBehaviour
{
    Queue<AudioSource> audioQueue = new Queue<AudioSource>(); //List of audio files, can grow as needed
    int index = 0; //index of array
    AudioSource currentAudioSource; //current audio source
    bool hasAudio;

    void Start()
    {
        currentAudioSource = audioQueue.Dequeue();

        if (audioQueue.Count > 0)
        {
            AudioPlay();
        }
    }

    public void AudioPlay()
    {
        if(!currentAudioSource.isPlaying)
        {
            currentAudioSource.Play(); //play audio source
            audioQueue.Dequeue(); //then dequeue it
        }
    }

    public void AddAudioSourceToList(AudioSource audioSource)
    {
        if(audioSource != null)
        {
            audioQueue.Enqueue(audioSource);
        }
    }	
}
