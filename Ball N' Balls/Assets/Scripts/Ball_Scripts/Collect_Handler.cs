using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect_Handler : MonoBehaviour, ICollectable
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ICollectable collectable))
        {
            collectable.Collect();
        }
    }
}
