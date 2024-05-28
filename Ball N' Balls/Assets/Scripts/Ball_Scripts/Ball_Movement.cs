using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        if (movement.magnitude > 1)
        {
            movement.Normalize();
        }

        //Debug.Log(movement.magnitude);
        //Debug.Log(rb.velocity.magnitude);   

        rb.AddForce(movement * speed, ForceMode.Force);
    }

}
