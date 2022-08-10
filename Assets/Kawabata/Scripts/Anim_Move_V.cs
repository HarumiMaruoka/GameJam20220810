using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Move_V : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 50.0f;
    [SerializeField]
    float yRange = 5.0f;

    float _rootPos;
    void Start()
    {
        _rootPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.y - _rootPos) > yRange)
        {
            moveSpeed *= -1;
        }
        transform.Translate(0f,moveSpeed * Time.deltaTime, 0f);
    }
}
