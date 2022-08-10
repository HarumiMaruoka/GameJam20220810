using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary> Player�̐ڐG������S������N���X </summary>
public class PlayerContact : MonoBehaviour
{
    // ************** �����o�[�ϐ� ************** //
    [Header("��Q���I�u�W�F�N�g�̃^�O�̖��O"), SerializeField] string _obstacleTagName;
    [Header("�X�R�A�A�C�e���̃^�O�̖��O"), SerializeField] string _scoreItemTagName;
    [Header("�S�[���I�u�W�F�N�g�̃^�O�̖��O"), SerializeField] string _gaolObjectTagName;
    [Header("���U���g�V�[���̖��O"), SerializeField] string _resultSceneName;

    [Header("�q�b�g�|�C���g"), SerializeField] int _hitPoint;
    [Header("�S�b�h���[�h"), SerializeField] bool _isGodMode;

    [Header("�G�l�~�[�q�b�g��̃S�b�h���[�h����"), SerializeField] float _godModeTime;
    [Header("�X�R�A�A�C�e���擾���̃X�R�A"), SerializeField] int _scoreItemsScore;

    // �����ɏՓ˂����Ƃ��ɌĂ΂�郁�b�Z�[�W
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Tag�Ŕ��肷��B
        // ��Q���ڐG�𔻒肷��
        if (collision.gameObject.tag == _obstacleTagName)
        {
            //�S�b�h���[�h�łȂ���΃_���[�W���󂯂�
            if (!_isGodMode)
            {
                StartCoroutine(Start_GodMode());
                _hitPoint--;

                //�̗͂�0�ȉ��ł���΃��U���g�V�[���ֈڍs
                if (_hitPoint <= 0)
                {
                    SceneManager.LoadScene(_resultSceneName);
                }
            }
        }
    }

    // �����ɐڐG������Ă΂�郁�b�Z�[�W
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Tag�Ŕ��肷��B
        // �X�R�A�A�C�e���ɐڐG������X�R�A�����Z
        if (collision.tag == _scoreItemTagName)
        {
            ScoreManager._score += _scoreItemsScore;
        }
        // �S�[���ɐڐG�����烊�U���g�V�[���ֈڍs����
        else if(collision.tag == _gaolObjectTagName)
        {
            SceneManager.LoadScene(_resultSceneName);
        }
    }

    /// <summary>  </summary>
    /// <returns></returns>
    IEnumerator Start_GodMode()
    {
        _isGodMode = true;
        yield return new WaitForSeconds(_godModeTime);
        _isGodMode = false;
    }
}
