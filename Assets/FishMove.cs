using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rb;

    void Start()
    {
        rb.velocity = transform.forward * speed;
    }

}

