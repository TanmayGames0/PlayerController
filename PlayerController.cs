using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 100f;
    private float turnSpeed = 50f;

    private bool isOnGround = true;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnGround == true)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");

            //Move the vehicle forward based on vertical input.
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            //Rotate the Vehicle base on horizontal input.
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        }
        else
        {
            isOnGround = false;
        }
    }
}
