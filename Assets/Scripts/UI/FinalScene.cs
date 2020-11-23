using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Diagnostics;

public class FinalScene : MonoBehaviour
{
    private GameObject gameInfo;
    TimeSpan playerTime;
    public Text stage;
    public Text timer;

    // Gameplay Rating
    public GameObject Boxs1, Boxs2, Boxs3;

    int hours;
    int minutes;
    int seconds;

    private void Start()
    {
        Boxs1.SetActive(false);
        Boxs2.SetActive(false);
        Boxs3.SetActive(false);

        gameInfo = GameObject.Find("GameInfo");
        playerTime = gameInfo.GetComponent<GameInfo>().timer;
        stage.text = $"Stage {gameInfo.GetComponent<GameInfo>().Stage}";

        int level = gameInfo.GetComponent<GameInfo>().Stage;

        if (playerTime.Hours > 99) hours = 99;
        else hours = playerTime.Hours;

        if (playerTime.Minutes > 99) minutes = 99;
        else minutes = playerTime.Minutes;

        if (playerTime.Seconds > 99) seconds = 99;
        else seconds = playerTime.Seconds;

        timer.text = $"{hours} : {minutes} : {seconds}";

        GetBoxsRating(level);
    }

    void GetBoxsRating(int stage)
    { 
        switch (stage)
        {
            // Rating configuration for stage 1
            case 1:
                if (minutes < 5) Boxs1.SetActive(true);
                if (minutes < 2) Boxs2.SetActive(true);
                if (minutes < 1) Boxs3.SetActive(true);
                break;

            // Rating configuration for stage 2
            case 2:
                if (minutes < 5) Boxs1.SetActive(true);
                if (minutes < 2) Boxs2.SetActive(true);
                if (minutes < 1) Boxs3.SetActive(true);
                break;

            // Rating configuration for stage 3
            case 3:
                if (minutes < 5) Boxs1.SetActive(true);
                if (minutes < 2) Boxs2.SetActive(true);
                if (minutes < 1) Boxs3.SetActive(true);
                break;

            // Error
            default:

                break;
        }
    }

}
