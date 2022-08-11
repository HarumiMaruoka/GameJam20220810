using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Rigidbody2D _rb;
    SpriteRenderer _sr;
    ParticleSystem _ps;

    [Header("レベルが変化するスコア数"), SerializeField] int _levelUpScore = 10;
    [Header("Animationが変わる上方向のスピード1"), SerializeField] float _changeUp1 = -0.8f;
    [Header("Animationが変わる上方向のスピード2"), SerializeField] float _changeUp2 = -0.5f;
    [Header("Animationが変わる上方向のスピード3"), SerializeField] float _changeUp3 = -0.2f;

    [SerializeField] Sprite[] _level1;
    [SerializeField] Sprite[] _level2;
    [SerializeField] Sprite[] _level3;

    [Header("クッキーのパーティクル"), SerializeField] GameObject[] _particle;

    bool _isChange;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
        _ps = GetComponent<ParticleSystem>();
    }


    void Update()
    {
        int level = ScoreManager._score / _levelUpScore;

        if (level > 1)
        {
            AnimationControl(_level3);
        }
        else if (level > 0)
        {           
            AnimationControl(_level2);
        }
        else
        {
            AnimationControl(_level1);
        }


        if (!_isChange)
        {
            _isChange = true;
            _ps.Play();
        }
    }

    void AnimationControl(Sprite[] sprite)
    {
        float speedY = _rb.velocity.y;
        Debug.Log(speedY);

        if (speedY != 0)
        {
            if (speedY > _changeUp3)
            {
                _sr.sprite = sprite[3];
            }
            else if (speedY > _changeUp2 || Input.GetKey(KeyCode.W))
            {
                _sr.sprite = sprite[2];
            }
            else if (speedY > _changeUp1)
            {
                _sr.sprite = sprite[1];
            }
        }
        else
        {
            _sr.sprite = sprite[0];
        }
    }
}
