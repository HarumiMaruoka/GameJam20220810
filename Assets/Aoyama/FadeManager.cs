using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeManager : MonoBehaviour
{
    [SerializeField] GameObject _fadePanel;

    void Start()
    {
        DontDestroyOnLoad(gameObject);

        FadeIn();
        SceneManager.sceneLoaded += SceneLoaded;
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("ResultScene");
        }
    }


    void SceneLoaded(Scene nextScene, LoadSceneMode mode)
    {
        FadeIn();
    }

    void FadeIn()
    {
        if (_fadePanel)
        {
            _fadePanel.SetActive(true);
        }
    }


    public void FadeInEnd()
    {
        gameObject.SetActive(false);
    }
}
