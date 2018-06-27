using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class MenuSelect : MonoBehaviour
{ 
    public VRTK_ControllerEvents controllerEvents;
    public GameObject menu;

    void OnEnable()
    {
       // controllerEvents.ButtonOnePressed += ControllerEvents_ButonOnePressed;
        //controllerEvents.ButtonOneReleased += ControllerEvents_ButonOneReleased;

    }
}
