using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(-transform.forward * 500);
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.forward * 500);
        }

        if (Input.GetKey(KeyCode.Q) && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.right * 500);
        }

        if (Input.GetKey(KeyCode.E) && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(-transform.right * 500);
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * 500);
        }

        if (Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(-transform.up * 500);
        }
    }

}
