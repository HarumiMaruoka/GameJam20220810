using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> �L�����p�X�Ɏ�������ׂ��R���|�[�l���g </summary>
public class DrawHitPoint : MonoBehaviour
{
    [Header("�n�[�g�̃X�v���C�g : �v���n�u"), SerializeField] GameObject _heartSpritePrefab;
    PlayerContact _playerHitPoint;
    [Header("player�̃^�O"), SerializeField] string _playerTagName;

    void Start()
    {
        _playerHitPoint = GameObject.FindGameObjectWithTag(_playerTagName).GetComponent<PlayerContact>();
        //�n�[�g�𐶐�����B
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
