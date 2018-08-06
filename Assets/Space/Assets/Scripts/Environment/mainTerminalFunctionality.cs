using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainTerminalFunctionality : MonoBehaviour
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
    

    SpriteRenderer sRenderer;
    public Sprite terminal;
    public Sprite terminalR;
    public Sprite terminalG;
    public Sprite terminalB;
    public Sprite terminalRG;
    public Sprite terminalRB;
    public Sprite terminalGB;
    public Sprite terminalRGB;
    void Update()
    {
        if (redKeyInserted == false && blueKeyInserted == false && greenKeyInserted == false)
        {
            GetComponent<SpriteRenderer>().sprite = terminal;
        }
        if (redKeyInserted == true)
        {
            GetComponent<SpriteRenderer>().sprite = terminalR;
        }
        if (greenKeyInserted == true)
        {
            GetComponent<SpriteRenderer>().sprite = terminalG;
        }
        if (blueKeyInserted == true)
        {
            GetComponent<SpriteRenderer>().sprite = terminalB;
        }
        if (redKeyInserted == true && blueKeyInserted == true)
        {
            GetComponent<SpriteRenderer>().sprite = terminalRB;
        }
        if (redKeyInserted == true && greenKeyInserted == true)
        {
            GetComponent<SpriteRenderer>().sprite = terminalRG;
        }
        if (blueKeyInserted == true && greenKeyInserted == true)
        {
            GetComponent<SpriteRenderer>().sprite = terminalGB;
        }
        if (redKeyInserted == true && blueKeyInserted == true && greenKeyInserted == true)
        {
            GetComponent<SpriteRenderer>().sprite = terminalRGB;
        }
    }


    private void OnTriggerStay(Collider col)
    {

        if (col.tag == "player")
        {
            if (KeyCardR.GetComponent<keyCardPickup>().holdingRedKey == true && Input.GetKeyDown(KeyCode.E))
            {
                redKeyInserted = true;
                KeyCardR.GetComponent<keyCardPickup>().holdingRedKey = false;
                
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
        }
    }

}

            
            
            