﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformm : MonoBehaviour
{
    public float speed;
    public Vector3 goalPosition;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, goalPosition, speed * Time.deltaTime);
    }
}