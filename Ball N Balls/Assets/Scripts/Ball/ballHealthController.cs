using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballHealthController : MonoBehaviour
{
    public static ballHealthController instance {  get; private set; }

    private Transform ball;
    private Transform SpawnPoint;

    public float health;

    public event Action loseGame;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        health = 5f;

        ball = GetComponent<Transform>();

        GameObject spawnpoint = GameObject.Find("SpawnPoint");

        if (spawnpoint != null)
        {
            SpawnPoint = spawnpoint.transform;
        }
        else
        {
            Debug.Log("SpawnPoint bulunamýyor!");
        }
        
        HealthBall.OnHBallCollected += IncreaseHealth;
    }

    private void Update()
    {
        HealthController();
    }

    void HealthController()
    {
        if (BallFallen())
        {
            health--;

            if (health <= 0)
            {
                LoseGame(); 
            }
            else
            {
                ResetBallPosition();
            }
        }     
    }

    private bool BallFallen()
    {
        return ball.transform.position.y < -5f;
    }

    void LoseGame()
    {
        loseGame?.Invoke();
    }

    private void ResetBallPosition()
    {
        ball.transform.position = SpawnPoint.transform.position;
    }

    void IncreaseHealth()
    {
        health++;
    }

    private void OnDestroy()
    {
        HealthBall.OnHBallCollected -= IncreaseHealth;
    }
}
