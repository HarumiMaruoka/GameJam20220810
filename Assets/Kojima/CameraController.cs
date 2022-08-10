using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    //�J�����̃X�N���[�����x
    [SerializeField]
    public float scrollSpeed = 10f;
    //�J�����̃X�^�[�g�ʒu
    private float startPosX;
    //�J�����̃S�[���ʒu
    [SerializeField]
    private float endPosX;
    //�J�����̃S�[���n�_�ł̔���
    bool isCamJudge = false;

    void Update()
    {
        if (transform.position.x <= endPosX)
        {
            transform.position = new Vector3(transform.position.x + (scrollSpeed * Time.deltaTime), 0, transform.position.z);
        }
        else if(transform.position.x >= endPosX && !isCamJudge)
        {
            transform.position = new Vector3(endPosX, 0, transform.position.z);
            isCamJudge = true;
        }
        Debug.Log(transform.position);
    }
}
