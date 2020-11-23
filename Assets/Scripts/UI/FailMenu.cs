using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailMenu : MonoBehaviour
{
    private GameObject gameInfo;
    private void Start()
    {
       gameInfo  = GameObject.Find("GameInfo");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Stage " + gameInfo.GetComponent<GameInfo>().Stage);
    }

    public void ExitToMainMenu()
    {
        Destroy(gameInfo);
        SceneManager.LoadScene(0);
    }
}
