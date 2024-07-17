using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    [SerializeField] private ballHealthController ballHealthController;

    private static MainManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            ballHealthController.loseGame += LoseGame;
            PauseMenu.mainMenuController += GotoMainMenu;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void LoseGame()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Level1");
    }

    private void GotoMainMenu()
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        ballHealthController.loseGame -= LoseGame;
        PauseMenu.mainMenuController -= GotoMainMenu;
    }
}
