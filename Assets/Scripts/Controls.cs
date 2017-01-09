using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {
    
    public Rigidbody2D rig;
    public float acceleration = 10;
    public float rotationSpeed = 1;
    public float rotationLimit = 300;

	// Use this for initialization
	void Start () {
	    rig = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float rotationalVelocity = Mathf.Abs(rig.angularVelocity); 
        if(Input.GetKey(KeyCode.W)){
            rig.AddForce(transform.up * acceleration);
        }else if(Input.GetKey(KeyCode.S)){
            // nok ikke bagud movement right/
        
        } else if(Input.GetKey(KeyCode.D)){
            if(rotationalVelocity <= rotationLimit) {
                rig.AddTorque(-rotationSpeed);
            }
        } else if(Input.GetKey(KeyCode.A)){
            if(rotationalVelocity <= rotationLimit) {
                rig.AddTorque(rotationSpeed);
            }
        }
        Debug.Log(rig.angularVelocity);
	}
}
