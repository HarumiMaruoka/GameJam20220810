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
    private float endPosX;

    void Update()
    {
        transform.position = new Vector3(transform.position.x + (scrollSpeed * Time.deltaTime), 0, transform.position.z);
        Debug.Log(transform.position);
    }
}
