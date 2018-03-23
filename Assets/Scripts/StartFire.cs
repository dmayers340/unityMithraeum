using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFire : MonoBehaviour {

    public GameObject torch;
    public ParticleSystem fire;

    void Start()
    {
        fire = fire.GetComponent<ParticleSystem>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == ("torch"))
        {
            fire.Play();
        }
    }
}
