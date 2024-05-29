using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_Ball : MonoBehaviour , ICollectable
{
    public void Collect()
    {
        Health_UI_Controller.instance.IncreaseHealth();
        Destroy(gameObject);
    }
}
