using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMenuButton : MonoBehaviour
{
    public void LoadScene(int levelIndex)
    {
        Application.LoadLevel(levelIndex);
    }
}
