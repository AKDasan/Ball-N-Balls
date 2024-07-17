using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera_Controller : MonoBehaviour
{
    private GameObject ball;
    [SerializeField] private Vector3 offset;

    private void Awake()
    {
        ball = GameObject.Find("Ball");
    }

    private void LateUpdate()
    {
        FollowBall();
    }

    void FollowBall()
    {
        if (ball != null)
        {
            transform.position = ball.transform.position + offset;
        }
    }
}
