using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

/*
 * This class logs how long a user spends on a level and writes it to a file called logfile.txt
 * */
public class LogTime : MonoBehaviour
{
    int userNumber = 7;
    string info = ""; 

    //Get time spent on Level
    string getTime()
    {
        string timeString = "Time Since Loaded : " + Time.timeSinceLevelLoad;

        return timeString;
    }

    //Get user
    string getUser()
    {
        string userNumberStr = userNumber.ToString();

        return userNumberStr;
    }
        
    void WriteToFile()
    {
        string file = "Assets/Resources/logfile.txt";

        StreamWriter writer = new StreamWriter(file, true);

        info = getTime() + " " + getUser();
        writer.WriteLine(info);
        writer.Close();

    }

}
