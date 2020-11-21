using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

public class Time : MonoBehaviour
{
    public Stopwatch stopwatch = new Stopwatch();
    // Start is called before the first frame update
    void Start()
    {
        stopwatch.Start();
        if(Input.GetKeyDown(KeyCode.Space)){
            stopwatch.Stop();
        }
    }

    // Update is called once per frame
    TimeSpan UpdateContinousStopwatch()
    {
        TimeSpan ts = stopwatch.Elapsed;
        return ts;
    }
}
