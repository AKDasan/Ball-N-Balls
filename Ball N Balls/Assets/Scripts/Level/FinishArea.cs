using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishArea : MonoBehaviour, IInteractable
{
    public static event Action Finish;

    public void Interact()
    {
        Finish?.Invoke();
    }
}
