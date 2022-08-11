using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultUI : MonoBehaviour
{
    [SerializeField]
    Text _result;
    [SerializeField]
    Text[] _choices;

    int choiceNum = 0;
    //メインシーンから受け取るスコア変数(仮)
    int score = ScoreManager._score;
    void Start()
    {
        _result = GameObject.Find("ResultScore").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //選択
        if (choiceNum > 0)
        {
            if (Input.GetKeyDown(KeyCode.W)) choiceNum--;
        }
        if (choiceNum < _choices.Length - 1)
        {
            if (Input.GetKeyDown(KeyCode.S)) choiceNum++;
        }
        foreach (Text choice in _choices)
        {
            choice.color = Color.black;
        }

        //表示
        _choices[choiceNum].color = new Color(210,0,0);
        _result.text = "Score:" + score;

        //シーン遷移
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (choiceNum == 0)
            {
                //タイトルへ
                ScoreManager._score = 0;
                SceneManager.LoadScene("TitleScene");
            }
            else if (choiceNum == 1)
            {
                //リスタート
                ScoreManager._score = 0;
                SceneManager.LoadScene(TitleScripts._sceneName);
            }
        }
    }

    //タイトルに戻るボタンで実行
    public void GoTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    //再挑戦ボタンで実行
    public void GoMain()
    {
        SceneManager.LoadScene(TitleScripts._sceneName);
    }
}
