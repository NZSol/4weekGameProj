using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyCardPickup : MonoBehaviour {

    public GameObject player;
    public GM MasterScript;

    internal bool holdingRedKey = false;
    internal bool holdingBlueKey = false;
    internal bool holdingGreenKey = false;

    bool inRange;
    float distanceFromKey;
    float keyPos;
    float playerPos;

    float invokeDelay = 1;

    // Use this for initialization
    void Start ()
    {
        invokeDelay = Time.deltaTime;
       // GetComponent<GM>().player = player;
        
    }


    private void OnTriggerStay(Collider col)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (gameObject.tag == "red")
            {
                holdingRedKey = true;
                Invoke("RemoveKey", invokeDelay);
                Debug.Log("test");
            }
            if (gameObject.tag == "green")
            {
                holdingGreenKey = true;
                Invoke("RemoveKey", invokeDelay);
            }
            if (gameObject.tag == "blue")
            {
                holdingBlueKey = true;
                Invoke("RemoveKey", invokeDelay);
            }
        }
    }

    void RemoveKey()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }
}
