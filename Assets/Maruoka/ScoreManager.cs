using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary> ただのスコアマネージャー </summary>
public class ScoreManager : MonoBehaviour
{
    static public int _score = 0;
    Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = "SCORE : " + _score;
    }
}
