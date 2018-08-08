using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyCardPickup : MonoBehaviour {

    public GameObject player;

    internal bool holdingRedKey = false;
    internal bool holdingBlueKey = false;
    internal bool holdingGreenKey = false;
    

    float distanceFromKey;
    float keyPos;
    float playerPos;

    float invokeDelay = 1;

    // Use this for initialization
    void Start ()
    {
        invokeDelay = Time.deltaTime;

    }

    private void Update()
    {
        keyPos = gameObject.transform.position.x + gameObject.transform.position.y;
        playerPos = player.transform.position.x + player.transform.position.y;
        distanceFromKey = playerPos - keyPos;

        Debug.Log(distanceFromKey);

        if (Input.GetKeyDown(KeyCode.E) && distanceFromKey < 0.5f && distanceFromKey > 0)
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

            Debug.Log("test");
        }
        
    }
    

    void RemoveKey()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }
}
