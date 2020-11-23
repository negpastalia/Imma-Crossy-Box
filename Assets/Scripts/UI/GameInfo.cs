using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

public class GameInfo : MonoBehaviour
{
    public int Stage;
    public TimeSpan timer;

    private void Start()
    {
        Stage = -1;
    }
}
