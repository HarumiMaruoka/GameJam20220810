using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerCon : MonoBehaviour
{
    private float STEP = 5.0f;

    void Update()
    {
        //‰EŒü‚«‚É“™‘¬‚Åi‚Ş
        this.transform.position += new Vector3(STEP * Time.deltaTime, 0, 0);
    }
}


