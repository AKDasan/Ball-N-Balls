using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_UI_Controller : MonoBehaviour
{
    public static Health_UI_Controller instance {  get; private set; }

    [SerializeField] GameObject targetParent;
    [SerializeField] GameObject health_ball;

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

    public void IncreaseHealth()
    {
        int tParentChild = targetParent.transform.childCount;

        if (tParentChild >= 0 && tParentChild < 5)
        {
            GameObject instantiatedHealth = Instantiate(health_ball);
            instantiatedHealth.transform.SetParent(targetParent.transform);
        }

        //Debug.Log(tParentChild);
    }
}
