﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float speed;

    void Update()
    {
        this.transform.Translate(new Vector3(0f, 0f, speed) * Time.deltaTime);
    }
}