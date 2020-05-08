using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OzMoveRight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x += .01f;
            this.transform.position = position;
        }
    }
}
