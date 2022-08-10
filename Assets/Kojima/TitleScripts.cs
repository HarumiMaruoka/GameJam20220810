using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScripts : MonoBehaviour
{
    //�X�^�[�g�{�^����I���Ŏ��s
    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
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
