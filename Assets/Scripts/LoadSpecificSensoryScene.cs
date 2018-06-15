using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * This script loads specific scenes based on the button press
 * This needs to be added to the Game Manager Object in the tutorial scene
 * */
public class LoadSpecificSensoryScene : MonoBehaviour
{
    public void LoadByIndex()
    {
        //If Press B button, load the base scene (at Index 1)
        if(Input.GetKeyDown("b"))
        {
            SceneManager.LoadScene(1);
            print("Loading Base Scene");
        }
        //If Press A button, load audio scene(at Index 2)
        else if(Input.GetKeyDown("a"))
        {
            SceneManager.LoadScene(2);
            print("Loading Audio Scene");

        }
        //If press S button, load scent scene(at Index 3)
        else if(Input.GetKeyDown("s"))
        {
            SceneManager.LoadScene(3);
            print("Loading Scent Scene");
        }
        //If press H button, load haptic scene(at Index 4)
        else if(Input.GetKeyDown("h"))
        {
            SceneManager.LoadScene(4);
            print("Loading Haptic Scene");
        }
        //If press M button, load multisensory scene(index 5)
        else if(Input.GetKeyDown("m"))
        {
            SceneManager.LoadScene(5);
            print("Loading Multisensory Scene");
        }

    }
}
