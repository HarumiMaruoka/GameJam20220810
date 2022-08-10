using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //*************** メンバー変数 ***************//
    Rigidbody2D _rigidbody2D;
    Vector3 _newVelocity;
    float _inputX;
    float _inputY;

    void Update()
    {
        Input_PlayerMove();
        Update_PlayerMove();
    }


    //*************** メンバー関数 ***************//
    /// <summary> 初期化関数 </summary>
    private void Initialized()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    /// <summary> 入力 </summary>
    private void Input_PlayerMove()
    {
    }

    /// <summary> 更新 </summary>
    private void Update_PlayerMove()
    {
        //リセット
        _newVelocity = Vector3.zero;
    }
}
