using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //*************** �����o�[�ϐ� ***************//
    Rigidbody2D _rigidbody2D;
    Vector3 _newVelocity;
    float _inputX;
    float _inputY;

    void Update()
    {
        Input_PlayerMove();
        Update_PlayerMove();
    }


    //*************** �����o�[�֐� ***************//
    /// <summary> �������֐� </summary>
    private void Initialized()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    /// <summary> ���� </summary>
    private void Input_PlayerMove()
    {
    }

    /// <summary> �X�V </summary>
    private void Update_PlayerMove()
    {
        //���Z�b�g
        _newVelocity = Vector3.zero;
    }
}
