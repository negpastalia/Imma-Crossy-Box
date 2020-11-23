using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioManager audioManager;

    public int status;

    void Start()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();

        switch (status)
        {
            case -1:
                audioManager.PlayBGMMainMenu();
                break;

            case 1:
                audioManager.PlayBGMStage1();
                break;

            case 2:
                audioManager.PlayBGMStage2();
                break;

            case 3:
                audioManager.PlayBGMStage3();
                break;
        }
        
    }
}
