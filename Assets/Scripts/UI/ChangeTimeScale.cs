using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTimeScale : MonoBehaviour
{
    public void TimeScaleModifier(float timeScale)
    {
        Time.timeScale = timeScale;
    }
}
