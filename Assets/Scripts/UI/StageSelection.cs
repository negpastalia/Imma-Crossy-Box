using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelection : MonoBehaviour
{
    public GameObject GameInfo;

    private void Start()
    {
        GameInfo = GameObject.Find("GameInfo");
    }

    public void BackToMainMenu()
    {
        Destroy(GameInfo);
        SceneManager.LoadScene(0);
    }

    public void SceneSelect(int stage)
    {
        switch (stage)
        {
            case 1:
                GameInfo.GetComponent<GameInfo>().Stage = 1;
                SceneManager.LoadScene("Stage 1");
                break;

            case 2:
                GameInfo.GetComponent<GameInfo>().Stage = 2;
                SceneManager.LoadScene("Stage 2");
                break;

            case 3:
                GameInfo.GetComponent<GameInfo>().Stage = 3;
                SceneManager.LoadScene("Stage 3");
                break;
        }
    }
}