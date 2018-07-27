using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberOfTorchesLit : MonoBehaviour
{
    public GameObject playerTorch;
    public GameObject endExperience;

    private int numTorchesLit = 0;
    PlayerCollideWithTorch torchScript;
    EndExperience endScript;

    //Get the torch script
    void Start()
    {
        torchScript = playerTorch.GetComponent<PlayerCollideWithTorch>();
        endScript = endExperience.GetComponent<EndExperience>();
    }

    void Update()
    {
        numTorchesLit = torchScript.getNumTorchesLit();
        if(numTorchesLit == 8)
        {
            endScript.PlayAudio();
            endScript.StopLights();
        }
    }

    //Get the number of torches lit
    public int GetNumberOfTorchesLit()
    {
        return numTorchesLit;
    }
}
