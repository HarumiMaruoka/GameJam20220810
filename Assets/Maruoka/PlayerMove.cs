using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //*************** メンバー変数 ***************//
    Rigidbody2D _rigidbody2D;
    Vector2 _newForce;
    Vector2 _newVelocity;
    float _inputX;
    float _inputY;

    [SerializeField]
    float upForce = 3.0f;
    [SerializeField]
    float sideSpeed = 2.0f;


    private void Start()
    {
        Initialized();
    }


    void FixedUpdate()
    {
        Update_PlayerMove();
    }


    void Update()
    {
        Input_PlayerMove();
        
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("aaa");
        }
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
        _inputY = Input.GetKey(KeyCode.W) ? 1 : 0;  //上昇
        _inputX = Input.GetAxis("Horizontal");      //左右移動
    }

    /// <summary> 更新 </summary>
    private void Update_PlayerMove()
    {
        //リセット
        _newVelocity = Vector2.zero;
        _newForce = Vector2.zero;

        //入力値から計算
        _newVelocity = new Vector2(_inputX * sideSpeed, 0);
        _newVelocity.y = _rigidbody2D.velocity.y;
        _newForce = new Vector2(0, _inputY * upForce);

        //X方向velocity、Y方向AddForceで更新
        _rigidbody2D.velocity = _newVelocity;
        _rigidbody2D.AddForce(_newForce);

        //velocityのパターン
        //if(_inputY == 0) _newVelocity.y = _rigidbody2D.velocity.y;
        //_rigidbody2D.velocity = _newVelocity;
    }
}
