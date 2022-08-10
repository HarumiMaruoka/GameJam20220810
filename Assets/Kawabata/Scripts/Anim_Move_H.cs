using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Move_H : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 100.0f;
    [SerializeField]
    float xRange = 5.0f;

    float _rootPos;
    void Start()
    {
        _rootPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.x - _rootPos) > xRange)
        {
            moveSpeed *= -1;
        }
        transform.Translate(moveSpeed * Time.deltaTime, 0f,0f);
    }
}
