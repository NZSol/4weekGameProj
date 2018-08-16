using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemPickup : MonoBehaviour {

    public GM Masterscript;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "ammo")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

            }
        }

        if (col.tag == "health")
        {

        }

        //if (collider.tag == "")
    }
}
