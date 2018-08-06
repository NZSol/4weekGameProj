using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keysOnScreen : MonoBehaviour {

    public GameObject player;
    public GameObject rKeyObj;
    public GameObject gKeyObj;
    public GameObject bKeyObj;

    public Image rKeyImg;
    public Image gKeyImg;
    public Image bKeyImg;

	// Use this for initialization
	void Start () {
        rKeyImg.enabled = false;
        gKeyImg.enabled = false;
        bKeyImg.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (rKeyObj.GetComponent<keyCardPickup>().holdingRedKey == true)
        {
            rKeyImg.enabled = true;
        }
        else
        {
            rKeyImg.enabled = false;
        }

        if (bKeyObj.GetComponent<keyCardPickup>().holdingBlueKey == true)
        {
            bKeyImg.enabled = true;
        }
        else
        {
            bKeyImg.enabled = false;
        }

        if (gKeyObj.GetComponent<keyCardPickup>().holdingGreenKey)
        {
            gKeyImg.enabled = true;
        }
        else
        {
            gKeyImg.enabled = false;
        }
    }
}
