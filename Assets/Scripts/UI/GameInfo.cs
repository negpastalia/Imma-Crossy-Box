using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

public class GameInfo : MonoBehaviour
{
    public int Stage;
    public TimeSpan timer;
    public bool DebugMode = false;

    public GameObject AudioManager;
    static bool spawnedGameInfo = false;

    private void Start()
    {
        Stage = -1;
        if (!spawnedGameInfo)
        {
            spawnedGameInfo = true;
            GameObject spawn = Instantiate(AudioManager);
            spawn.name = "AudioManager";
        }
    }
}
