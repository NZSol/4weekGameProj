using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minorTerminalBehaviour : MonoBehaviour
{

    public GameObject KeyCardR;
    public GameObject KeyCardB;
    public GameObject KeyCardG;
    public GameObject player;

    public bool redKeyInserted = false;
    public bool blueKeyInserted = false;
    public bool greenKeyInserted = false;

    float distanceFromTerminal;
    float playerPos;
    float terminalPos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerStay(Collider col)
    {

        if (col.tag == "player")
        {
            if (KeyCardR.GetComponent<keyCardPickup>().holdingRedKey == true && Input.GetKeyDown(KeyCode.E))
            {
                redKeyInserted = true;
                KeyCardR.GetComponent<keyCardPickup>().holdingRedKey = false;

                Debug.Log(redKeyInserted);
            }

            if (KeyCardB.GetComponent<keyCardPickup>().holdingBlueKey == true && Input.GetKeyDown(KeyCode.E))
            {
                blueKeyInserted = true;
                KeyCardB.GetComponent<keyCardPickup>().holdingBlueKey = false;

            }

            if (KeyCardG.GetComponent<keyCardPickup>().holdingGreenKey == true && Input.GetKeyDown(KeyCode.E))
            {
                greenKeyInserted = true;
                KeyCardG.GetComponent<keyCardPickup>().holdingGreenKey = false;

            }

            /*
            if (redKeyInserted == true && Input.GetKeyDown(KeyCode.E) && KeyCardB.GetComponent<keyCardPickup>().holdingBlueKey == false && KeyCardG.GetComponent<keyCardPickup>().holdingGreenKey == false)
            {
                KeyCardR.GetComponent<keyCardPickup>().holdingRedKey = true;
                redKeyInserted = false;
            }

            if (blueKeyInserted == true && Input.GetKeyDown(KeyCode.E) && KeyCardR.GetComponent<keyCardPickup>().holdingRedKey == false && KeyCardG.GetComponent<keyCardPickup>().holdingGreenKey == false)
            {
                KeyCardB.GetComponent<keyCardPickup>().holdingBlueKey = true;
                blueKeyInserted = false;
            }

            if (greenKeyInserted == true && Input.GetKeyDown(KeyCode.E) && KeyCardB.GetComponent<keyCardPickup>().holdingBlueKey == false && KeyCardB.GetComponent<keyCardPickup>().holdingBlueKey == false)
            {
                KeyCardG.GetComponent<keyCardPickup>().holdingGreenKey = true;
                greenKeyInserted = false;
            }
            */
        }
    }

}

