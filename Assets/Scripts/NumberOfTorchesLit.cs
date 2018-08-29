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
        this.numTorchesLit = torchScript.getNumTorchesLit();
    }

    //Get the number of torches lit
    public int GetNumberOfTorchesLit()
    {
        return numTorchesLit;
    }
}
