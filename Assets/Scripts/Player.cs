using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}
public class Player : MonoBehaviour
{
    public float speed;
    public Boundary boundary;

}

void FixedUpdate()
{
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
}
	
	// Update is called once per frame
	void Update ()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
	}
}
