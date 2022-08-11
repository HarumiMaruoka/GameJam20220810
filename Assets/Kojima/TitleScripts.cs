using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScripts : MonoBehaviour
{
    public static string _sceneName;
    //�X�^�[�g�{�^����I���Ŏ��s
    public void GameStart(string stageName)
    {
        ScoreManager._score = 0;
        _sceneName = stageName;
        SceneManager.LoadScene(stageName);

    }
    public void Explan()
    {
        SceneManager.LoadScene("GameExplanScene");
    }
    public void Back()
    {
        SceneManager.LoadScene("TitleScene");
    }

    //�G���h�{�^����I���Ŏ��s
    public void GameEnd()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
