using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.VR; //This is UnityEngine.XR in more recent editions Head tracking and positional tracking automatically applied
public class GameController : MonoBehaviour
{ //refresh rate should be 90hz to reduce nausea

    //public static string[] GetJoystickNames();
    public static string loadedDeviceName;
    private void Start()
    {
        StartCoroutine(LoadDevice("Split"));

        int i = 0;
        while(i<4)
        {
            if (Mathf.Abs(Input.GetAxis("Joy" + i + "X")) > 0.2F || Mathf.Abs(Input.GetAxis("Joy" + i + "Y")) > 0.2F)
            {
                Debug.Log(Input.GetJoystickNames()[i] + " is moved");
                Debug.Log(loadedDeviceName);
            }
            else { 
}
            i++;
        }
    }

    IEnumerator LoadDevice(string newDevice)
    {
        VRSettings.LoadDeviceByName(newDevice); //XRSettings in more recent editions
        yield return null;
        VRSettings.enabled = true;
    }
    void Update ()
    {
        //if at anytime the user pushes Escape, go to main Menu
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }

    }
}
