using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Keep a queue of audio files to play when called
 * If user enters a Sound Zone, the audio should be placed in the queue to be played once the previous 
 * audio source finishes playing
 * */
public class AudioQueue : MonoBehaviour
{
   Queue<AudioSource> audioQueue = new Queue<AudioSource>();

    //Changed to list
    List<AudioSource> audio2Queue = new List<AudioSource>(); //Queue of audio files, can grow as needed
    AudioSource currentAudioSource; //current audio source

    int index = 0;
    bool hasAudio;

    /*
     * If no audio is playing and there are audio source in the queue:
     * 1.) Get the currentAudioSource
     * 2.) Play the audio,
     * 3.) Get the next audioSource from the queue 
     *  4.) Play that audio
    */
    public void AudioPlay()
    {

        currentAudioSource = audio2Queue[index];
        if(!currentAudioSource.isPlaying)
        {
            currentAudioSource.Play();
            index += 1;
        }


        /*
         * Queue Error Message: Object reference not set to an instance of an object
AudioQueue.AudioPlay () (at Assets/Scripts/AudioQueue.cs:40)
PlaySound.PlayAudio () (at Assets/Scripts/PlaySound.cs:46)
PlaySound.OnTriggerEnter (UnityEngine.Collider other) (at Assets/Scripts/PlaySound.cs:36)

         if(!currentAudioSource.isPlaying)
         {
             RemoveAudioSourceToPlay();
         }
         */

    }

    /* This checks to see if there is audio in the queue
     * 
     * */
    private bool hasAudioInQueue()
    {
        if (audio2Queue.Count > 0)
        {
            hasAudio = true;
        }
        else
        {
            hasAudio = false;
        }

        return hasAudio;
    }

    /*
    public AudioSource RemoveAudioSourceToPlay()
    {
        currentAudioSource = audioQueue.Dequeue();
        return currentAudioSource;
    }
    */


    /*
     * This is to communicate with the PlayAudio script
     * If a player runs into an audio zone, Play Audio will add the audio source to the queue and then start the play function
     * */
    public void AddAudioSourceToList(AudioSource audioSource)
    {
        if (audioSource != null)
        {
           // audioQueue.Enqueue(audioSource);

            audio2Queue.Add(audioSource);
          //  Debug.Log("Added Audio To Queue! Size: " + audioQueue.Count);

            Debug.Log("Added Audio To Queu2e! Size: " + audio2Queue.Count);
        }
        else
        {
            Debug.Log("Cannot add audio, no source found");
        }
    }

    public int getSize()
    {
        return audio2Queue.Count;
    }
}