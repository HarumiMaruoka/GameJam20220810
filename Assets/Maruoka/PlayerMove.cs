using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //*************** �����o�[�ϐ� ***************//
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


    //*************** �����o�[�֐� ***************//
    /// <summary> �������֐� </summary>
    private void Initialized()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    /// <summary> ���� </summary>
    private void Input_PlayerMove()
    {
        _inputY = Input.GetKey(KeyCode.W) ? 1 : 0;  //�㏸
        _inputX = Input.GetAxis("Horizontal");      //���E�ړ�
    }

    /// <summary> �X�V </summary>
    private void Update_PlayerMove()
    {
        //���Z�b�g
        _newVelocity = Vector2.zero;
        _newForce = Vector2.zero;

        //���͒l����v�Z
        _newVelocity = new Vector2(_inputX * sideSpeed, 0);
        _newVelocity.y = _rigidbody2D.velocity.y;
        _newForce = new Vector2(0, _inputY * upForce);

        //X����velocity�AY����AddForce�ōX�V
        _rigidbody2D.velocity = _newVelocity;
        _rigidbody2D.AddForce(_newForce);

        //velocity�̃p�^�[��
        //if(_inputY == 0) _newVelocity.y = _rigidbody2D.velocity.y;
        //_rigidbody2D.velocity = _newVelocity;
    }
}
