using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public event Action SceneLoadEvent;
    public event Action SceneLoadedEvent;

    [SerializeField] private Animator animator;

    private void Start()
    {
        FinishArea.Finish += FinishTrigger;
    }

    IEnumerator LoadNextScene()
    {
        SceneLoadEvent?.Invoke();
        int buildIndex = SceneManager.GetActiveScene().buildIndex;

        animator.SetTrigger("FinishLevel");

        yield return new WaitForSeconds(1f);
 
        SceneManager.LoadScene(buildIndex + 1);
        animator.SetTrigger("SceneLoaded");
        SceneLoadedEvent?.Invoke();
    }

    void FinishTrigger()
    {
        StartCoroutine(LoadNextScene());
    }

    private void OnDestroy()
    {
        FinishArea.Finish -= FinishTrigger;
    }
}
