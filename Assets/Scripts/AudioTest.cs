using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{

    public AudioClip[] clipArray;
    public GameObject soundObj;
    AudioSource audio;

    private int count = 0;
    private int numZonesEntered = 0;

    bool hasEntered = false;

    void Start()
    {
        audio = soundObj.GetComponent<AudioSource>();
    }

    //This currently will play each one and cut off the clip if enter anoterh zone
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("zone"))
        {
            numZonesEntered++;
            for (int i = 0; i < numZonesEntered; i++)
            {
                audio.clip = clipArray[i];
                count++;
                if(!audio.isPlaying)
                {
                    audio.Play();
                }
            }
        }
        other.tag = "entered";

        /*This will go through zones, and not overplay but not play the next one.
         * if(other.CompareTag("zone"))
        {
            numZonesEntered++;
            Debug.Log("Number Zones Entered: " + numZonesEntered);

            
            for (int i = 0; i < numZonesEntered; i++)
            {
                audio.clip = clipArray[i];
                count++;
            
                 audio.Play();
                
            }
        }
        */
    }
  //  public Queue<AudioSource> audioSourceQueue = new Queue<AudioSource>();

  //  AudioSource currentAudioSource;

  //  int index = 0;
   // bool hasEntered = false;
   // bool hasBeenAdded = false;

    //void Update()
    //{
      //  GetAudio();
    //}
    //This plays the audio over each other
    /*
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("zone"))
        {
            AddAudioToQueue(other.GetComponent<AudioSource>());
            currentAudioSource = GetAudio();
            currentAudioSource.Play();
        }

        /*
        currentAudioSource = GetAudio();
        if(!currentAudioSource.isPlaying && hasEntered == false)
        {
            hasEntered = true;
            currentAudioSource.Play();
        }
        */
        //    }
        /*
            void AddAudioToQueue(AudioSource audioToAdd)
            {
                if(audioToAdd != null) //&& hasBeenAdded == false)
                {
                    hasBeenAdded = true;
                    audioSourceQueue.Enqueue(audioToAdd);
                    Debug.Log("Added audio to queue. Count: " + audioSourceQueue.Count);
                }
                else
                {
                    Debug.Log("Cannot add, no audio or has already been added");
                }
            }

            AudioSource GetAudio()
            {
                return audioSourceQueue.Dequeue();
            }
            */
        /*
        public AudioClip[] audioSources; //Array of Audio Files to Play at each sound zone (9 zones)
        private AudioClip currentAudioClip; //The current audio clip
        public GameObject audioObj; //Object that holds the queue
        private AudioSource audioSource; //The audio source from audioObj
        int index = 0; //Index of array
        bool hasAudio = false; //if the array has audio or not
        bool hasEntered = false; //if the user has entered a zone or not
        private int numZonesEntered = 0;

        void Start()
        {
            audioSource = audioObj.GetComponent<AudioSource>(); //get the audio source, ONLY 1 AUDIO SOURCE
        }

        //IF no audio is playing, and player has collided into a zone, get the clip to play
        public void AudioPlay()
        {
            while(index < 9)
            //while(!audioSource.isPlaying)
            {
                if (!audioSource.isPlaying) //if a clip is not playing
                {
                    audioSource.clip = audioSources[index]; //set the clip equal to the index
                    audioSource.Play(); //play the audio
                    index = index + 1; //increase the index
                }
                Debug.Log("Index is now at: " + index);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
           // audioSource = audioObj.GetComponent<AudioSource>(); //get the audio source, ONLY 1 AUDIO SOURCEa
            if (other.CompareTag("zoneA") && hasEntered == false)
            {
                hasEntered = true;
                Debug.Log("Entered Zone A");
                audioSource.clip = audioSources[0];
                audioSource.Play();
            }
            else if(other.CompareTag("zoneB") && hasEntered == false)
            {
                hasEntered = true;
                Debug.Log("Entered Zone b");
                audioSource.clip = audioSources[1];
                audioSource.Play();
            }
            else if (other.CompareTag("zoneC") && hasEntered == false)
            {
                hasEntered = true;
                Debug.Log("Entered Zone c");
                if (!audioSource.isPlaying)
                {
                    audioSource.clip = audioSources[2];
                    audioSource.Play();
                }
            }
            else if (other.CompareTag("zoneD") && hasEntered == false)
            {
                hasEntered = true;
                Debug.Log("Entered Zone D");
                if (!audioSource.isPlaying)
                {
                    audioSource.clip = audioSources[3];
                    audioSource.Play();
                }
            }
            else if (other.CompareTag("zoneE") && hasEntered == false)
            {
                hasEntered = true;
                Debug.Log("Entered Zone E");
                audioSource.clip = audioSources[4];
                audioSource.Play();
            }
            else if (other.CompareTag("zoneF") && hasEntered == false)
            {
                hasEntered = true;
                Debug.Log("Entered Zone F");
                audioSource.clip = audioSources[5];
                audioSource.Play();
            }
            else if (other.CompareTag("zoneG") && hasEntered == false)
            {
                hasEntered = true;
                Debug.Log("Entered Zone G");
                audioSource.clip = audioSources[6];
                audioSource.Play();
            }
            else if (other.CompareTag("zoneH") && hasEntered == false)
            {
                hasEntered = true;
                Debug.Log("Entered Zone H");
                audioSource.clip = audioSources[7];
                audioSource.Play();
            }
            else if (other.CompareTag("zoneI") && hasEntered == false)
            {
                hasEntered = true;
                Debug.Log("Entered Zone I");
                audioSource.clip = audioSources[8];
                audioSource.Play();
            }
        }
        */
    }
