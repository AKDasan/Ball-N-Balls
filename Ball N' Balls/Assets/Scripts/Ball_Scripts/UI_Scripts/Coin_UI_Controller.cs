using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin_UI_Controller : MonoBehaviour
{
    public static Coin_UI_Controller instance {  get; private set; }

    [SerializeField] TextMeshProUGUI CoinText;

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

    public void IncreaseCoin()
    {
        int CoinValue = int.Parse(CoinText.text);
        CoinValue += 50;
        CoinText.text = CoinValue.ToString();
    }
}
