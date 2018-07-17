using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    private Queue<AudioClip> queueClips = new Queue<AudioClip>();

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
        }
    }

    public void PlayAudio()
    {
        while (queueClips.Count != 0)
        {
            AudioClip clipToPlay = GetAudioClip();
            audioSource.clip = clipToPlay;
            // audioSource.PlayOneShot(clipToPlay);
            audioSource.Play();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("zone"))
        {
            AudioSource toAdd = other.GetComponent<AudioSource>();
            AudioClip clipToAdd = toAdd.clip;
            Add(clipToAdd);
        }
    }

    public AudioClip GetAudioClip()
    {
        AudioClip current = queueClips.Dequeue();
        return current;
    }
}


