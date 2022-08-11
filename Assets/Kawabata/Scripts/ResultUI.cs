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
    //���C���V�[������󂯎��X�R�A�ϐ�(��)
    int score = ScoreManager._score;
    void Start()
    {
        _result = GameObject.Find("ResultScore").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //�I��
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

        //�\��
        _choices[choiceNum].color = new Color(210,0,0);
        _result.text = "Score:" + score;

        //�V�[���J��
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (choiceNum == 0)
            {
                //�^�C�g����
                ScoreManager._score = 0;
                SceneManager.LoadScene("TitleScene");
            }
            else if (choiceNum == 1)
            {
                //���X�^�[�g
                ScoreManager._score = 0;
                SceneManager.LoadScene(TitleScripts._sceneName);
            }
        }
    }

    //�^�C�g���ɖ߂�{�^���Ŏ��s
    public void GoTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    //�Ē���{�^���Ŏ��s
    public void GoMain()
    {
        SceneManager.LoadScene(TitleScripts._sceneName);
    }
}
