using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpSwitch : MonoBehaviour {

    public bool canJump = true;

    public bool jumpReady = true;
    float jumpForce = 5;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && canJump == true && jumpReady == true)
        {
            GetComponentInParent<Rigidbody>().AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "ground")
        {
            jumpReady = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "ground")
        {
            jumpReady = false;
        }
    }
}
