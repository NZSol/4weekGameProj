using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    internal bool canMove = true;
    internal Rigidbody rb;

    float speed = 0.2f;
    float climb = 0.1f;
    public bool onLadder;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKey(KeyCode.A) && canMove == true && onLadder == false)
        {
            gameObject.transform.position -= new Vector3(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D) && canMove == true && onLadder == false)
        {
            gameObject.transform.position += new Vector3(speed, 0, 0);             
        }

        if (onLadder == true)
        {        
            if (Input.GetKey(KeyCode.D))
            {
               gameObject.transform.position += new Vector3(speed / 3, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                gameObject.transform.position -= new Vector3(speed / 3, 0, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                gameObject.transform.position += new Vector3(0, climb, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                gameObject.transform.position -= new Vector3(0, climb, 0);
            }
        
        }

    }


    private void OnTriggerStay(Collider other)
    {
        //TestFunc(other);
        if (other.tag == "ladder")
        {
            onLadder = true;
            GetComponent<Rigidbody>().useGravity = false;
        }
    }


    private void OnTriggerExit(Collider col)
    {
        onLadder = false;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
