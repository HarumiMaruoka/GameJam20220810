using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> キャンパスに持たせるべきコンポーネント </summary>
public class DrawHitPoint : MonoBehaviour
{
    [Header("ハートのスプライト : プレハブ"), SerializeField] GameObject _heartSpritePrefab;
    PlayerContact _playerHitPoint;
    [Header("playerのタグ"), SerializeField] string _playerTagName;
    [Header("ハートを置く場所 : このオブジェクトの子にハートを生成する。layout groupを持つので"), SerializeField] Transform _placeToPutHeart;

    void Start()
    {
        _playerHitPoint = GameObject.FindGameObjectWithTag(_playerTagName).GetComponent<PlayerContact>();
        //ハートを生成する。
        for (int i = 0; i < _playerHitPoint._hitPoint; i++)
        {

        }
    }

    void Update()
    {

    }
}
