using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, ICollectable
{
    public void Collect()
    {
        Coin_UI_Controller.instance.IncreaseCoin();
        Audio_Manager.instance.CoinCollectSound();
        Destroy(gameObject);
    }
}
