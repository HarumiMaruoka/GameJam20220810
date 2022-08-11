using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScripts : MonoBehaviour
{
    static string _sceneName;
    [Header("���C���V�[����"), SerializeField] string _stage1Name;
    [Header("���C���V�[����"), SerializeField] string _stage2Name;
    //�X�^�[�g�{�^����I���Ŏ��s
    public void GameStart()
    {
        ScoreManager._score = 0;
        _sceneName = _stage1Name;
        SceneManager.LoadScene(_stage1Name);

    }
    public void Stage2()
    {
        _sceneName = _stage2Name;
        SceneManager.LoadScene(_stage2Name);
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
