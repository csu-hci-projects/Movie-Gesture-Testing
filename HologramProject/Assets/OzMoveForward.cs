﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OzMoveForward : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.z += .01f;
            this.transform.position = position;
        }
    }
}