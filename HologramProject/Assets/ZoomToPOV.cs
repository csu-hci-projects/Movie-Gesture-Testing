using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomToPOV : MonoBehaviour
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
			   Vector3 pos = GameObject.Find("MazeLowMan (1)").transform.position;
				Quaternion rot = GameObject.Find("MazeLowMan (1)").transform.rotation;
            Vector3 position = this.transform.position;
				Quaternion rotation = this.transform.rotation;
				
				pos.y += (float)0.45;
								
				Vector3 diff = pos - position;
									
				if (position != pos) {
					position.x += diff.x/50;
            	position.y += diff.y/50;
					position.z += diff.z/50;
				}
				
				if (rot != rotation) {
					this.transform.rotation = Quaternion.RotateTowards(rotation, rot, (float)0.5);
				}
				
            this.transform.position = position;
        }
    }
	 
	 
}