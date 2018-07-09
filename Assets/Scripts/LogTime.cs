using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This class logs how long a user spends on a level and writes it to a file called logfile.txt
 * 1.) Get time spent on each level
 * 2.) Print out amount of time for each player
 * 
 * I did not want to print out the time so often in Debug.Log, so am using the unity tutorial
 * https://unity3d.com/learn/tutorials/projects/roll-ball-tutorial/displaying-score-and-text?playlist=17141
 * to print out the total time at the end
 * */
public class LogTime : MonoBehaviour
{
    int userNumber = 0;
    float timeSpent;

    //Empty Constructor
    public LogTime()
    {

    }

    void Start()
    {
        timeSpent = 0;
    }

    //Get time spent on Level
   void Update()
    {
        timeSpent = timeSpent + Time.deltaTime;
       // Debug.Log("Time Spent: " + Mathf.RoundToInt(timeSpent).ToString());
    }

    public string getTimeSpent()
    {
        return Mathf.RoundToInt(timeSpent).ToString();
    }
    //On ApplicationQuit
    void OnApplicationQuit()
    {
        Debug.Log(" From Log Time: Time Spent: " + Mathf.RoundToInt(timeSpent).ToString());
    }

    
}
