using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Rotate : MonoBehaviour
{
    [SerializeField]
    float _rotationSpeed = 180.0f; //•b‘¬

    void Update()
    {
        transform.Rotate(new Vector3(0f,0f,_rotationSpeed*Time.deltaTime));
    }
}
