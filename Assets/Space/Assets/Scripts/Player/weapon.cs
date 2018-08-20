﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {
    
    public GameObject bulletClone;
    public GameObject bullet;
    GameObject Player;
    Vector3 playerPos;
    GM masterScript;



    public int ammoCount = 3;

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update () {

        Player = GameObject.FindWithTag("player");
        playerPos = new Vector3(Player.transform.position.x, Player.transform.position.y + 0.05f, 0);

        if (ammoCount > 0 && Input.GetKeyDown(KeyCode.Mouse0) && Player.GetComponent<SpriteRenderer>().flipX == true)
        {
            bulletClone = Instantiate(bullet, playerPos, Quaternion.identity);
            ammoCount--;
            bulletClone.GetComponent<Rigidbody>().velocity += new Vector3(5, 0, 0);
        }
        else if (ammoCount > 0 && Input.GetKeyDown(KeyCode.Mouse0) && Player.GetComponent<SpriteRenderer>().flipX == false)
        {
            bulletClone = Instantiate(bullet, playerPos, Quaternion.identity);
            bulletClone.GetComponent<SpriteRenderer>().flipX = true;
            ammoCount--;
            bulletClone.GetComponent<Rigidbody>().velocity -= new Vector3(5, 0, 0);
        }
	}

}
