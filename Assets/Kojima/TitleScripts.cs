using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScripts : MonoBehaviour
{
    //スタートボタンを選択で実行
    public void GameStart()
    {
        ScoreManager._score = 0;
        SceneManager.LoadScene("GameScene");
    }

    //エンドボタンを選択で実行
    public void GameEnd()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
