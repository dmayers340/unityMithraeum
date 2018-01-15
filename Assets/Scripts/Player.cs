using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    private Quaternion mouseRotate;
    /* I want my player to rotate when the camera rotates
     * Need to get the rotation of the camera and rotate player based on position
     * */
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical"); //allows w/ arrow or WASD
        float moveHorizontal = Input.GetAxis("Horizontal");

        /*change my x and z values based on camera position --get info from MouseLook Script
        get x input from camera
        get y input from camera
        */

        //  Quaternion newRotation = m_MouseLook.getRotation();
        // rb.transform.rotation = newRotation;
     
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(-movement * speed);

    }

    
}
