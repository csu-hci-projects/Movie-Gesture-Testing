﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSmaller : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 scale = this.transform.localScale;
            scale -= new Vector3(.020f, .020f, .020f);
            this.transform.localScale = scale;

        }
    }
}