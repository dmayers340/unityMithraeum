using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnTorch : MonoBehaviour
{
    private Light torchLight;

	// Use this for initialization
	void Start ()
    {
        torchLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            torchLight.enabled = !torchLight.enabled; //toggles switch on and off
        }
		
	}
}
