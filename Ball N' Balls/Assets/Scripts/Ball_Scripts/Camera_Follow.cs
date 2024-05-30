using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    [SerializeField] private Transform ball;
    [SerializeField] private Vector3 offset;

    private void LateUpdate()
    {
        if (ball != null)
        {
            transform.position = ball.position + offset;
        }
    }
}
