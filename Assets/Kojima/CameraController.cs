using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    //カメラのスクロール速度
    [SerializeField]
    public float scrollSpeed = 10f;
    //カメラのスタート位置
    private float startPosX;
    //カメラのゴール位置
    [SerializeField]
    private Transform endPosX;
    //カメラのゴール地点での判定
    bool isCamJudge = false;

    void Update()
    {
        if (transform.position.x <= endPosX.position.x)
        {
            transform.position = new Vector3(transform.position.x + (scrollSpeed * Time.deltaTime), 0, transform.position.z);
        }
        else if(transform.position.x >= endPosX.position.x && !isCamJudge)
        {
            transform.position = new Vector3(endPosX.position.x, 0, transform.position.z);
            isCamJudge = true;
        }
    }
}
