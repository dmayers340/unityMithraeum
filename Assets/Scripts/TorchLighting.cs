using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchLighting : MonoBehaviour
{
    public ParticleSystem fire;
    public List<ParticleCollisionEvent> lightingEvents;

    // Use this for initialization
    void Start ()
    {
        fire = GetComponent<ParticleSystem>();
        lightingEvents = new List<ParticleCollisionEvent>();
       
	}
	
	// Update is called once per frame
	void Update ()
    {
       
		
	}
}
