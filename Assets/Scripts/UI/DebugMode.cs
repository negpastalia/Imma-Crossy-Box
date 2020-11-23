using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugMode : MonoBehaviour
{
    public GameInfo gameInfo;
    public Toggle debugMode;

    private void Start()
    {
        if (gameInfo.DebugMode) debugMode.isOn = true;
        else debugMode.isOn = false;
    }
    public void Check()
    {
        if (debugMode.isOn)
        {
            EnableDebugMode();
        }
        if (!debugMode.isOn)
        {
            DisableDebugMode();
        }
    }

    void EnableDebugMode()
    {
        gameInfo.DebugMode = true;
    }

    void DisableDebugMode()
    {
        gameInfo.DebugMode = false;
    }
}
