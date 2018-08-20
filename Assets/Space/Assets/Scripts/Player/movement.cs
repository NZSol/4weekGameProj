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

    private bool isCrouching;


    Vector3 regMovementSpeed;
    Vector3 slowMovementSpeed;
    Vector3 regCrouchSpeed;
    Vector3 slowCrouchSpeed;
    
	// Use this for initialization
	void Start () {
        regMovementSpeed = new Vector3(speed, 0, 0);
        slowMovementSpeed = new Vector3(speed / 2, 0, 0);
        regCrouchSpeed = new Vector3(crouchSpeed, 0, 0);
        slowCrouchSpeed = new Vector3(crouchSpeed / 2, 0, 0);

        isCrouching = false;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //if (crouching == false)
        //{
        //    if (Input.GetKey(KeyCode.A) && canMove == true)
        //    {
        //        gameObject.transform.position -= regMovementSpeed;
        //    }

        //    if (Input.GetKey(KeyCode.D) && canMove == true)
        //    {
        //        gameObject.transform.position += regMovementSpeed;
        //    }

        //    if (Input.GetKeyDown(KeyCode.LeftControl) && canMove == true)
        //    {
        //        print("thing");
        //        crouching = true;
        //        //crouchCheck();
        //    }
        //}

        //else if (crouching == true)
        //{
        //    if (Input.GetKey(KeyCode.A) && canMove == true)
        //    {
        //        gameObject.transform.position -= regCrouchSpeed;
        //    }

        //    if (Input.GetKey(KeyCode.D) && canMove == true)
        //    {
        //        gameObject.transform.position += regCrouchSpeed;
        //    }

        //    if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftControl))
        //    {
        //        print("otherThing");
        //        //crouchCheck();
        //        crouching = false;
        //    }

        //}


        if (Input.GetKeyDown(KeyCode.LeftControl) == true && canMove == true)
        {
            crouchCheck();
            print(isCrouching);
        }


        if (isCrouching == false)
        {
            Walk();
        }
        else
        {
            Crouch();
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


    void Walk()
    {
        if (gameObject.GetComponent<SpriteRenderer>().flipX == true)
        {
            if (Input.GetKey(KeyCode.A) && canMove == true)
            {
                gameObject.transform.position -= slowMovementSpeed;
            }

            if (Input.GetKey(KeyCode.D) && canMove == true)
            {
                gameObject.transform.position += regMovementSpeed;
            }

        }
        else
        {
            if (Input.GetKey(KeyCode.A) && canMove == true)
            {
                gameObject.transform.position -= regMovementSpeed;
            }

            if (Input.GetKey(KeyCode.D) && canMove == true)
            {
                gameObject.transform.position += slowMovementSpeed;
            }

        }
        
    }

    void Crouch()
    {
        if (gameObject.GetComponent<SpriteRenderer>().flipX == true)
        {
            if (Input.GetKey(KeyCode.A) && canMove == true)
            {
                gameObject.transform.position -= slowCrouchSpeed;
            }

            if (Input.GetKey(KeyCode.D) && canMove == true)
            {
                gameObject.transform.position += regCrouchSpeed;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.A) && canMove == true)
            {
                gameObject.transform.position -= regCrouchSpeed;
            }

            if (Input.GetKey(KeyCode.D) && canMove == true)
            {
                gameObject.transform.position += slowCrouchSpeed;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            crouchCheck();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //TestFunc(other);
        if (other.tag == "ladder")
        {
            onLadder = true;
            crouching = false;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }


    private void OnTriggerExit(Collider col)
    {
        onLadder = false;
        GetComponent<Rigidbody>().useGravity = true;
    }

    void crouchCheck()
    {
        isCrouching = !isCrouching;
    }
}
