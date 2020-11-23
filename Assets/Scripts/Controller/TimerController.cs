using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

public class TimerController : MonoBehaviour
{
    public Stopwatch stopwatch = new Stopwatch();

    public TimeSpan GetFinalTime()
    {
        stopwatch.Stop();
        TimeSpan ts = stopwatch.Elapsed;
        return ts;
    }

    public void StartStopwatch()
    {
        stopwatch.Reset();
        stopwatch.Start();
    }

    public void PauseStopwatch() { stopwatch.Stop(); }
    public void ResumeStopwatch() { stopwatch.Start(); }

}
