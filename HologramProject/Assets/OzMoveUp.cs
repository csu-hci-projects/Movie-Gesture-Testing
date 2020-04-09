using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OzMoveUp : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y += .03f;
            this.transform.position = position;
        }
    }
}