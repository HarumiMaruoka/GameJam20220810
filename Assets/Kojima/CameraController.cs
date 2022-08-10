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
    private float endPosX;

    void Update()
    {
        transform.position = new Vector3(transform.position.x + (scrollSpeed * Time.deltaTime), 0, transform.position.z);
        Debug.Log(transform.position);
    }
}
