using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kukkiGene : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("クッキーたち"), SerializeField]
    GameObject[] _cookies;
    float num;
    float span = 0.05f;
    float time = 0;
    float timecount = 0;

    void Start()
    {
        num = Random.Range(10, 20);
        timecount = span;
    }

    // Update is called once per frame
    void Update()
    {
        if(timecount >2.0f)
        {
            return;
        }
        time += Time.deltaTime;
        if(time > span)
        {
            timecount = time + span;
            var id = Random.Range(0, _cookies.Length);
            if (id < _cookies.Length && id > 0)
            {
                var x = Random.Range(-8, 9);
                var y = Random.Range(5, 9);
                var c = GameObject.Instantiate(_cookies[id]);
                c.transform.position = new Vector3(x, y, 0);
            }
        }


    }
}
