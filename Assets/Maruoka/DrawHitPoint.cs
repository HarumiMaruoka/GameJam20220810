using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> �L�����p�X�Ɏ�������ׂ��R���|�[�l���g </summary>
public class DrawHitPoint : MonoBehaviour
{
    [Header("�n�[�g�̃X�v���C�g : �v���n�u"), SerializeField] GameObject _heartSpritePrefab;
    PlayerContact _playerHitPoint;
    [Header("player�̃^�O"), SerializeField] string _playerTagName;
    [Header("�n�[�g��u���ꏊ : ���̃I�u�W�F�N�g�̎q�Ƀn�[�g�𐶐�����Blayout group�����̂�"), SerializeField] Transform _placeToPutHeart;

    void Start()
    {
        _playerHitPoint = GameObject.FindGameObjectWithTag(_playerTagName).GetComponent<PlayerContact>();
        //�n�[�g�𐶐�����B
        for (int i = 0; i < _playerHitPoint._hitPoint; i++)
        {

        }
    }

    void Update()
    {

    }
}
