using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHitDetect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "player")
        {
            gameObject.GetComponent<BoxCollider>().isTrigger = false;
        }
    }
}
