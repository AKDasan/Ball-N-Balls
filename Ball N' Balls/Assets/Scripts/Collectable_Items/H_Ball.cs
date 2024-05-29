using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H_Ball : MonoBehaviour , ICollectable
{
    public void Collect()
    {
        // Ball toplanýldýðýnda yapýlacak iþlemler...
        Destroy(gameObject);
    }
}
