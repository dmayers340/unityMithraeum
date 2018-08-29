using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This script will track what the user was looking at
 * 1.) Attach to VRTK? Or Player? Or Camera??
 * 2.) Check rotation of Camera? Or position?
 * 3.) Use heatmap shader and send video?
 * 4.) UNITY Gaze mapping--use raycast
 * 
 * A Raycast is a 'beam' from the origin until hit a collider
 * 
 * This was NOT implemented
 * */

public class VRUserLookingAt : MonoBehaviour
{
    public Camera hmdCamera;

    void Update()
    {
        RaycastHit hit;
        
        Ray lookRay = new Ray(hmdCamera.transform.position, hmdCamera.transform.forward);

        if (Physics.Raycast(lookRay, out hit))
        {
            if(hit.collider.CompareTag("environment"))
            {
                Debug.Log("Looking at the scene sy " + hit.distance);
            }  
        }
        Debug.DrawRay(hmdCamera.transform.position, hmdCamera.transform.forward, Color.black, 1);

    }
}
