using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{

public void LoadByIndex(int sceneIndex) //setting value in button
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
