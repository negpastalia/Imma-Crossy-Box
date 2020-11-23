using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerController : MonoBehaviour
{
    public Image powerBar;

    bool isFull;
    int speed;

    private void Start()
    {
        isFull = false;
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (powerBar.fillAmount == 1) isFull = true;
        if (powerBar.fillAmount == 0) isFull = false;

        if (!isFull) powerBar.fillAmount += Time.deltaTime * speed;
        else powerBar.fillAmount -= Time.deltaTime * speed;
    }

    public float GetPowerAmount()
    {
        return powerBar.fillAmount;
    }
}
