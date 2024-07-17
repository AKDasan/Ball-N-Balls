using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ICollectable collect))
        {
            collect.Collect();
        }

        if (other.TryGetComponent(out IInteractable interact))
        {
            interact.Interact();
        }
    }
}
