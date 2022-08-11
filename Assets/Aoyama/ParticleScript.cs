using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    [SerializeField] float _destroyTime = 5;
    
    void Start()
    {
        Destroy(gameObject, _destroyTime);
    }
}
