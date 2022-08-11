using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Rigidbody2D _rb;
    Animator _animator;  

    [Header("レベルが変化するスコア数"),SerializeField] int _levelUpScore = 10;
    [Header("Animationが変わる上方向のスピード"),SerializeField] float _changeUp = 0.2f;

    [SerializeField] Sprite[] _charactor; 


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();

        _animator.Play("FlyOne");
    }


    void Update()
    {
        if (_animator)
        {
            AnimationControl();
        }
    }

    void AnimationControl()
    {
        float speedY = _rb.velocity.y;
        int level = ScoreManager._score / _levelUpScore;

        if ((speedY > _changeUp && speedY != 0) || Input.GetKey(KeyCode.W))
        {
            if (level > 1)
            {
                _animator.Play("UpThree");
            }
            else if (level > 0)
            {
                _animator.Play("UpTwo");
            }
            else
            {
                _animator.Play("UpOne");
            }        
        }
        else
        {
            if (level > 1)
            {
                _animator.Play("FlyThree");
            }
            else if (level > 0)
            {
                _animator.Play("FlyTwo");
            }
            else
            {
                _animator.Play("FlyOne");
            }
        }
    }
}
