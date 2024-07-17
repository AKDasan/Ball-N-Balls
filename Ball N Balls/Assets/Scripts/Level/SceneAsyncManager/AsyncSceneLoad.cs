using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AsyncSceneLoad : MonoBehaviour
{
    public static AsyncSceneLoad Instance;

    [SerializeField] private GameObject LoadingScreen;

    [SerializeField] private Slider LoadingSlider;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }        
    }

    private void Start()
    {
        LoadingScreen.SetActive(false);
    }

    public void LoadLevel(int buildIndex)
    {
        LoadingScreen.SetActive(true);

        StartCoroutine(LoadLevelAsync(buildIndex));
    }

    IEnumerator LoadLevelAsync(int buildIndex)
    {
        AsyncOperation load = SceneManager.LoadSceneAsync(buildIndex);

        while (!load.isDone)
        {
            LoadingSlider.value = load.progress;
            yield return null;
        }

        yield return new WaitForSeconds(0.5f);
        LoadingScreen.SetActive(false);
    }
}
