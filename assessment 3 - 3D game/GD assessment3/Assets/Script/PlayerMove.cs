using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float jumpPower;

    private void Start()
    {

        rb = GetComponent<Rigidbody>();
        speed = speed * Time.deltaTime;
    }

    private void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(Vector3.forward * speed , ForceMode.Impulse);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(Vector3.back * speed * 0.8f);
        }
        if (Input.GetKey("a")) 
        { 
            rb.AddForce(Vector3.left * speed );
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(Vector3.right * speed );
        }
        if (Input.GetKeyDown("space")) 
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }

    }

}
