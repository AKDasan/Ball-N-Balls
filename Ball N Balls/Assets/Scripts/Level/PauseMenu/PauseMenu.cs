using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    private bool isPauseMenuOpen;

    public static event Action mainMenuController;

    private void Awake()
    {
        pauseMenu.SetActive(false);
        isPauseMenuOpen = false;
    }

    private void Update()
    {
        PauseMenuController();
    }

    private void PauseMenuController()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPauseMenuOpen = !isPauseMenuOpen;
            pauseMenu.SetActive(isPauseMenuOpen);
        }
    }

    public void MainMenuBTN()
    {
        mainMenuController?.Invoke();      
        AsyncSceneLoad.Instance.LoadLevel(0);
    }
}
