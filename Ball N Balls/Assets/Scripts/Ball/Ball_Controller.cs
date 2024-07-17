using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float speed;

    [SerializeField] private Transform SpawnPoint;
    [SerializeField] private LevelManager levelManager;

    private bool isStopped;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        levelManager.SceneLoadEvent += Ball_StopMove;
        levelManager.SceneLoadedEvent += SetBallPosition;
        levelManager.SceneLoadedEvent += Ball_MoveController;
    }

    private void FixedUpdate()
    {
        if (!isStopped)
        {
            Ball_Movement();
        }       
    }

    public void Ball_Movement()
    {
        Vector3 force = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        rb.AddForce(force * speed * Time.fixedDeltaTime);
    }

    void Ball_StopMove()
    {
        rb.velocity = Vector3.zero;
        isStopped = true;
    }

    void Ball_MoveController()
    {
        if (isStopped)
        {
            isStopped = false;
        }        
    }

    public void SetBallPosition()
    {
       transform.position = SpawnPoint.position;
    }

    private void OnDestroy()
    {
        levelManager.SceneLoadEvent -= Ball_StopMove;
        levelManager.SceneLoadedEvent -= SetBallPosition;
        levelManager.SceneLoadedEvent -= Ball_MoveController;
    }
}
