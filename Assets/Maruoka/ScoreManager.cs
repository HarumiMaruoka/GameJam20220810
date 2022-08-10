using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary> ただのスコアマネージャー </summary>
public class ScoreManager : MonoBehaviour
{
    public GameObject scoreObj= null;
    static public int _score = 0;

    void Update()
    {
       Text scoreText = scoreObj.GetComponent<Text>();
        scoreText.text = "SCORE:" + _score;
    }
}
