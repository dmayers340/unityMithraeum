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
 * */

    /*
     * Ray origin at center eye 
     * */
public class VRUserLookingAt : MonoBehaviour
{
    public Camera hmdCamera;

    void Start()
    {
        RaycastHit hit;
        Ray lookRay = new Ray(Vector3 origin, Vector3 direction);

        if (Physics.Raycast(lookRay, out hit))
        {
            Transform objectHit = hit.transform;
            //create heatmap
       
        }
)

    }
        //raycast = collider hit-which objects intersected by ray
        //distance and layermask-place objects if ray ignroed
        //origin and direction = ray
}
