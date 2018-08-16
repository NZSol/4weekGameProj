using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    internal bool canMove = true;
    internal Rigidbody rb;

    float speed = 0.2f;
    float crouchSpeed = 0.1f;
    float climb = 0.1f;
    public bool onLadder;
    public bool crouching = false;
    bool walking = true;

    private bool isCrouching;


    Vector3 movementSpeed;
    Vector3 CrouchSpeed;
    
	// Use this for initialization
	void Start () {
        movementSpeed = new Vector3(speed, 0, 0);
        CrouchSpeed = new Vector3(crouchSpeed, 0, 0);

        isCrouching = false;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (crouching == false)
        {
            if (Input.GetKey(KeyCode.A) && canMove == true)
            {
                gameObject.transform.position -= movementSpeed;
            }

            if (Input.GetKey(KeyCode.D) && canMove == true)
            {
                gameObject.transform.position += movementSpeed;
            }

            if (Input.GetKeyDown(KeyCode.LeftControl) && canMove == true)
            {
                print("thing");
                crouching = true;
                //crouchCheck();
            }
        }

        else if (crouching == true)
        {
            if (Input.GetKey(KeyCode.A) && canMove == true)
            {
                gameObject.transform.position -= CrouchSpeed;
            }

            if (Input.GetKey(KeyCode.D) && canMove == true)
            {
                gameObject.transform.position += CrouchSpeed;
            }

            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftControl))
            {
                print("otherThing");
                //crouchCheck();
                crouching = false;
            }

        }
        

        //if (Input.GetKeyDown(KeyCode.LeftControl) == true)
        //{
        //    crouchCheck();
        //}


        //if (isCrouching == false)
        //{
        //    Walk();
        //}
        //else
        //{
        //    Crouch();
        //}


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


    void Walk()
    {
        print("Walk");
    }

    void Crouch()
    {
        print("Crouch");
    }

    private void OnTriggerStay(Collider other)
    {
        //TestFunc(other);
        if (other.tag == "ladder")
        {
            onLadder = true;
            crouching = false;
            walking = false;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }


    private void OnTriggerExit(Collider col)
    {
        onLadder = false;
        walking = true;
        GetComponent<Rigidbody>().useGravity = true;
    }

    void crouchCheck()
    {
        //walking = !walking;
        //crouching = !crouching;
        isCrouching = !isCrouching;
    }
}
