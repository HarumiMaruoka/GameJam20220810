using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScripts : MonoBehaviour
{
    [Header("���C���V�[����"), SerializeField] string _stage1Name;
    //�X�^�[�g�{�^����I���Ŏ��s
    public void GameStart()
    {
        ScoreManager._score = 0;
        SceneManager.LoadScene(_stage1Name);
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
