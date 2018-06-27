using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogTime : MonoBehaviour {

    public Button sceneButton;
    public Text thisText;
    public int sceneIndex;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(GameObject.Find("canvas"));

        if(sceneButton != null)
        {
            sceneButton.onClick.AddListener(LoadSceneButton);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        thisText.text = "Time Since Level Was Loaded: " + Time.timeSinceLevelLoad;
	}

    void LoadSceneButton()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
