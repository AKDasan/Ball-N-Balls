using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBall : MonoBehaviour, ICollectable
{
    public static event Action OnHBallCollected;

    // veya

    //public delegate void HealthBallCollected();
    //public static event  HealthBallCollected OnHBallCollected;

    public void Collect()
    {
        OnHBallCollected?.Invoke();
        Destroy(gameObject);
    }
}
