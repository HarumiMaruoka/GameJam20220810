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
        if(choiceNum　> 0)
        {
            if(Input.GetKeyDown(KeyCode.W)) choiceNum--;
        }
        if(choiceNum < _choices.Length - 1)
        {
            if (Input.GetKeyDown(KeyCode.S)) choiceNum++;
        }
        foreach(Text choice in _choices)
        {
            choice.color = Color.black;
        }
        _choices[choiceNum].color = Color.yellow;
        _result.text = "Score:" + score;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(choiceNum == 0)
            {
                SceneManager.LoadScene("TitleScene");
            }else if(choiceNum == 1)
            {
                SceneManager.LoadScene("MainScene");
            }
        }
    }
}
