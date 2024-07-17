using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIHealthManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthText;

    void Update()
    {
        ConvertHealth();
    }

    void ConvertHealth()
    {
        healthText.text = ballHealthController.instance.health.ToString();
    }
}
