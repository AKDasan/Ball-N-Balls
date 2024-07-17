using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [SerializeField] private float jumpForce = 500f;

    public static event Action OnBallCollision;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody ballRB = collision.gameObject.GetComponent<Rigidbody>();
            if (ballRB != null)
            {
                ballRB.AddForce(transform.up * jumpForce);
                OnBallCollision?.Invoke();
            }
        }
    }
}
