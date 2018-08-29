/*
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    private MouseLook m_MouseLook;
    private Rigidbody rb;
    Quaternion originalRotation;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

       // originalRotation = m_MouseLook.getRotation();
 
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
}

*/