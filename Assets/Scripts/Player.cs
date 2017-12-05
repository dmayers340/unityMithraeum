using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical"); //allows w/ arrow or WASD
        float moveHorizontal = Input.GetAxis("Horizontal");

        //change my x and z values based on camera position 
        //get x input from camera
        //get y input from camera

        /*
        Vector3 playerRotate = new Vector3(Input.GetAxis("Mouse X"), 0, Input.GetAxis("Mouse Y"));

        Quaternion direction = Quaternion.LookRotation(playerRotate);
        transform.rotation = Quaternion.Lerp(transform.rotation, direction, Time.deltaTime);
    
    */
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(-movement * speed);

    }

}
