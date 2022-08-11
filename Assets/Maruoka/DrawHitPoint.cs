using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> キャンパスに持たせるべきコンポーネント </summary>
public class DrawHitPoint : MonoBehaviour
{
    [Header("ハートのスプライト : プレハブ"), SerializeField] GameObject _heartSpritePrefab;
    PlayerContact _playerHitPoint;
    [Header("playerのタグ"), SerializeField] string _playerTagName;

    void Start()
    {
        _playerHitPoint = GameObject.FindGameObjectWithTag(_playerTagName).GetComponent<PlayerContact>();
        //ハートを生成する。
        for (int i = 0; i < _playerHitPoint._hitPoint; i++)
        {
            Instantiate(_heartSpritePrefab, transform);
        }
    }


    private void OnEnable()
    {

    }

    void Update()
    {
        if (transform.childCount != _playerHitPoint._hitPoint)
        {
            if (transform.childCount < _playerHitPoint._hitPoint)
            {
                for (int i = 0; i < Mathf.Abs(transform.childCount - _playerHitPoint._hitPoint); i++)
                {
                    Instantiate(_heartSpritePrefab, transform);
                }
            }

            else if (transform.childCount > _playerHitPoint._hitPoint)
            {
                for (int i = 0; i < Mathf.Abs(transform.childCount - _playerHitPoint._hitPoint); i++)
                {
                    Destroy(transform.GetChild(i).gameObject);
                }
            }
        }
    }
}
