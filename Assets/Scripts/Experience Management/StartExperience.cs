using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Start of the experience. Mithras voice will play, Mithras will say he will light the torch, light torch and play torch sound upon lighting.
 * Steps:
 * 1.) Attach to StartExperience Game Object, really can be attached to any game object
 * 2.) Start with Dark Lighting (Directional light is down, only light from the torches on fort and altar light is shown)
 * 3.) Play sound clip 
 * 4.) When sound ends turn on torch light and torch sound
 * */
public class StartExperience : MonoBehaviour
{
    public AudioSource godAudio;
    public AudioSource torchAudio;

    public GameObject torch;
    private ParticleSystem ps;

    public AudioClip grabTorchAudioClip;
    public AudioClip godAudioClipStart;

    //Set up the Particle System, torch Audio, god audio and play god voice
    void Start ()
    {
        ps = torch.GetComponent<ParticleSystem>();
        godAudio = GetComponent<AudioSource>();
        torchAudio = torch.GetComponent<AudioSource>();
        grabTorchAudioClip = GetComponent<AudioClip>();


        //Play God Auido
        godAudio.clip = godAudioClipStart;
        godAudio.Play();

        //Once the first clip finishes, play the second clip
        //does not get into here
        if (!godAudio.isPlaying)
        {
            godAudio.clip = grabTorchAudioClip;
            godAudio.Play();
           // PlayParticleSystem();
        }
    }

    void Update ()
    {
        //Once the god is done speaking, turn on the light and play torch sound
        PlayParticleSystem();
	}

    //The audio for the player torch is acting strangely
    void PlayParticleSystem()
    {
        if (!godAudio.isPlaying)
        {
            ps.Play();
            torchAudio.Play();
        }
    }
    
}
