using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void StartGameController()
    {
        AsyncSceneLoad.Instance.LoadLevel(1);
    }
}
