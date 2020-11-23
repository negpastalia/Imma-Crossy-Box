using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;

    public PowerController powerController;
    public TimerController timerController;
    public GameObject gameInfo;

    public GameObject pauseMenu;
    public GameObject
        inputQ, inputW, inputE, inputA, inputS, inputD;
    public Sprite
        inputQDeactive, inputQActive,
        inputWDeactive, inputWActive,
        inputEDeactive, inputEActive,
        inputADeactive, inputAActive,
        inputSDeactive, inputSActive,
        inputDDeactive, inputDActive;

    public bool isAlive;
    public bool isPause;
    public int allowMove;

    private void Start()
    {
        Cursor.visible = false;
        Time.timeScale = 1;
        isAlive = true;
        isPause = false;
        allowMove = 3;
        rb = GetComponent<Rigidbody>();
        gameInfo = GameObject.Find("GameInfo");

        timerController.StartStopwatch();
    }

    private void Update()
    {
        // Player Controller
        if (!isPause && isAlive)
        {
            if (Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.Space)) rb.AddForce(-transform.forward * PushPlayer());
            if (Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.Space)) rb.AddForce(transform.forward * PushPlayer());
            if (Input.GetKey(KeyCode.Q) && Input.GetKeyDown(KeyCode.Space)) rb.AddForce(transform.right * PushPlayer());
            if (Input.GetKey(KeyCode.E) && Input.GetKeyDown(KeyCode.Space)) rb.AddForce(-transform.right * PushPlayer());
            if (Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.Space)) rb.AddForce(transform.up * PushPlayer());
            if (Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.Space)) rb.AddForce(-transform.up * PushPlayer());

            if (Input.GetKeyDown(KeyCode.Q)) inputQ.GetComponent<SpriteRenderer>().sprite = inputQActive;
            if (Input.GetKeyUp(KeyCode.Q)) inputQ.GetComponent<SpriteRenderer>().sprite = inputQDeactive;

            if (Input.GetKeyDown(KeyCode.W)) inputW.GetComponent<SpriteRenderer>().sprite = inputWActive;
            if (Input.GetKeyUp(KeyCode.W)) inputW.GetComponent<SpriteRenderer>().sprite = inputWDeactive;

            if (Input.GetKeyDown(KeyCode.E)) inputE.GetComponent<SpriteRenderer>().sprite = inputEActive;
            if (Input.GetKeyUp(KeyCode.E)) inputE.GetComponent<SpriteRenderer>().sprite = inputEDeactive;

            if (Input.GetKeyDown(KeyCode.A)) inputA.GetComponent<SpriteRenderer>().sprite = inputAActive;
            if (Input.GetKeyUp(KeyCode.A)) inputA.GetComponent<SpriteRenderer>().sprite = inputADeactive;

            if (Input.GetKeyDown(KeyCode.S)) inputS.GetComponent<SpriteRenderer>().sprite = inputSActive;
            if (Input.GetKeyUp(KeyCode.S)) inputS.GetComponent<SpriteRenderer>().sprite = inputSDeactive;

            if (Input.GetKeyDown(KeyCode.D)) inputD.GetComponent<SpriteRenderer>().sprite = inputDActive;
            if (Input.GetKeyUp(KeyCode.D)) inputD.GetComponent<SpriteRenderer>().sprite = inputDDeactive;
        }

        // Esc Menu
        if (Input.GetKeyDown(KeyCode.Escape) && isAlive)
        {
            PauseGame();
        }
    }

    float PushPlayer()
    {
        float power = 0;

        if (allowMove != 0)
        {
            allowMove--;
            power = powerController.GetPowerAmount();
            StartCoroutine(DelayFor(3));
        }
        else power = 0;

        return power * 500;
    }

    IEnumerator DelayFor(int second)
    {
        yield return new WaitForSeconds(second);
        allowMove = 3;
    }

    public void PauseGame()
    {
        if (pauseMenu.activeSelf)
        {
            Cursor.visible = false;
            isPause = false;
            timerController.ResumeStopwatch();
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
        else
        {
            Cursor.visible = true;
            isPause = true;
            timerController.PauseStopwatch();
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car" && isAlive)
        {
            Cursor.visible = true;
            isAlive = false;
            isPause = true;
            Time.timeScale = 0;
            SceneManager.LoadScene("Fail Scene", LoadSceneMode.Additive);
        }

        if (other.gameObject.tag == "Win" && isAlive)
        {
            Cursor.visible = true;
            isPause = true;
            Time.timeScale = 0;
            gameInfo.GetComponent<GameInfo>().timer = timerController.GetFinalTime();
            SceneManager.LoadScene("FinishScene", LoadSceneMode.Additive);
        }
    }
}
