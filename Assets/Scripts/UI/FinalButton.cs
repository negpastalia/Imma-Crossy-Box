using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalButton : MonoBehaviour
{
    private GameObject gameInfo;
    private void Start()
    {
        gameInfo = GameObject.Find("GameInfo");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Stage " + gameInfo.GetComponent<GameInfo>().Stage);
    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
