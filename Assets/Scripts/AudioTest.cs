using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{
    AudioSource audioSource;
    Queue<AudioSource> queuAudio = new Queue<AudioSource>();

    private Queue<AudioClip> queueClips = new Queue<AudioClip>();

    AudioClip clip;
    bool hasEnteredZone = false;

    public void AddAudioSource(AudioSource source)
    {
        bool hasBeenAdded = false;

       queuAudio.Enqueue(source);

        if(queuAudio.Count == 1 && !source.isPlaying && hasBeenAdded == false)
        {
            PlayAudio();
            hasBeenAdded = true;
        }
        Debug.Log("Added Audio Source to Queue: " + queuAudio.Count);
        
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
       // AudioClip clip = queueClips.Dequeue();
        //audioSource.clip = clip;

        AudioSource toPlay = queuAudio.Dequeue();
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
           // AudioSource toAdd = other.GetComponent<AudioSource>();
            //AudioClip clipToAdd = toAdd.clip;
          //  Add(clipToAdd);
        }
    }
}


