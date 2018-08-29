using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTestQueue : MonoBehaviour
{
    AudioSource audioSource;
    Queue<AudioSource> queueOfAudio = new Queue<AudioSource>();

    private Queue<AudioClip> queueClips = new Queue<AudioClip>();

    AudioClip clip;
    bool hasEnteredZone = false;

    public void AddAudioSource(AudioSource source)
    {
        bool hasBeenAdded = false;

       queueOfAudio.Enqueue(source);

        if(queueOfAudio.Count == 1 && !source.isPlaying && hasBeenAdded == false)
        {
            PlayAudio();
            hasBeenAdded = true;
        }
        Debug.Log("Added Audio Source to Queue: " + queueOfAudio.Count);
        
    }

    //Add the audio clip to the queue
    public void Add(AudioClip clip)
    {
        if (clip != null)
        {
            queueClips.Enqueue(clip);
            Debug.Log("Added Clip. Count is: " + queueClips.Count);
        }
        if (queueClips.Count == 1)
        {
            PlayAudio();
            Debug.Log("Audio is being Played");
        }
    }

    //Play the audio by getting the clip from the queue
    public void PlayAudio()
    {
        AudioSource toPlay = queueOfAudio.Dequeue();
       if (!toPlay.isPlaying)
       {
            toPlay.Play();   
       }
    }

    //When the player enters, get the audio source
    //Then get the clip from that source and put in the queue
    //Then Play the audio from the queue
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("zone"))
        {
            AudioSource zoneSource = other.GetComponent<AudioSource>();
            AddAudioSource(zoneSource);
        }
    }
}


/**
 *     Queue<AudioSource> audioQueue = new Queue<AudioSource>(); //List of audio files, can grow as needed
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
**/