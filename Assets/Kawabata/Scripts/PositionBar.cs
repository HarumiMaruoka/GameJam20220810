using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionBar : MonoBehaviour
{
    Slider _slider;
    Vector2 _startpos = Vector2.zero;
    Vector2 _endpos;
    
    void Start()
    {
        _slider = GetComponent<Slider>();
        _endpos = GameObject.Find("Goal").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = (Camera.main.transform.position.x - _startpos.x) / (_endpos.x - _startpos.x); 
    }
}
