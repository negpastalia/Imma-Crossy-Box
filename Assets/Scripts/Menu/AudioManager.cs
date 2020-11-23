using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgm;

    public AudioClip bgmMainMenu;
    public AudioClip bgmStage1;
    public AudioClip bgmStage2;
    public AudioClip bgmStage3;

    static bool spawnedAudioManager = false;

    private void Start()
    {
        if (!spawnedAudioManager)
        {
            DontDestroyOnLoad(gameObject);
            spawnedAudioManager = true;
        }
    }

    public void PlayBGMMainMenu()
    {
        bgm.clip = bgmMainMenu;
        bgm.Play();
    }

    public void PlayBGMStage1()
    {
        bgm.clip = bgmStage1;
        bgm.Play();
    }

    public void PlayBGMStage2()
    {
        bgm.clip = bgmStage2;
        bgm.Play();
    }

    public void PlayBGMStage3()
    {
        bgm.clip = bgmStage3;
        bgm.Play();
    }


}
