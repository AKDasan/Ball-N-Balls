using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Controller : MonoBehaviour
{
    public static Level_Controller instance {  get; private set; }

    [SerializeField] GameObject ball;
    [SerializeField] GameObject targetParent;
    private int health_Amount;
    [SerializeField] float fallYposition = -10f;

    [SerializeField] private Transform firstSpawnPoint;
    public Vector3 lastCheckPoint;

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
    }

    private void Update()
    {
        if (lastCheckPoint == null)
        {
            lastCheckPoint = firstSpawnPoint.position;
        }

        if (ball.transform.position.y <= fallYposition)
        {
            fallingBall();
        }      
    }

    void fallingBall()
    {
        Health_UI_Controller.instance.DecreaseHealth();
        health_Amount = targetParent.transform.childCount;

        if (health_Amount == 0)
        {
            SceneManager.LoadScene("Level1");
        }
        else
        {
            ball.transform.position = lastCheckPoint;
        }
    }

    public void updateCheckPoint(Transform position)
    {
        if (position != null)
        {
            lastCheckPoint = position.position;
        }
    }
}
