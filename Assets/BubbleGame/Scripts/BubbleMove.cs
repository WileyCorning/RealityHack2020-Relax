﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMove : MonoBehaviour
{
    [SerializeField] BubbleColorCode colorCode;
    public BubbleColorCode ColorCode => colorCode;

    [SerializeField] float lifespan = 2f;
    [SerializeField] float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifespan);
    }

    internal void Pop(bool good) {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }
}