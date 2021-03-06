﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    public float rotationSpeed;
    public Vector3 rotationDirection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * (speed * Time.deltaTime));

        transform.Rotate(rotationDirection * (rotationSpeed * Time.deltaTime));
    }
}
