﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{

    GameObject playerClone;
    float respawnDelay;
    public Vector3 spawnPos;
    Vector3 initialSpawn;

    public screenFade canvas;
    public keyCardPickup[] kcp;

    public GameObject player;
    public GameObject CanvasGroup;
    public GameObject Spawner1;
    public GameObject Spawner2;
    public GameObject Spawner3;

    // Use this for initialization
    void Start()
    {
        playerClone = Instantiate(player, initialSpawn, Quaternion.identity) as GameObject;
        playerClone.GetComponent<healthSystem>().MasterScript = gameObject.GetComponent<GM>();
        respawnDelay = 1 * Time.deltaTime;
        initialSpawn = new Vector3(-2, 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playerDeath()
    {
       // canvas.fadeOut();
    }

    public void playerRespawn()
    {
       // CanvasGroup.GetComponent<screenFade>().fadeIn();
    }

    public void checkDeath()
    {
        playerDeath();
        //checkSpawn();
        Invoke("ReLife", respawnDelay);
    }

    void checkSpawn()
    {
        //if (GetComponent<spawnPoints>().point1 == true)
        //{
        //    spawnPos = GetComponent<spawnPoints>().transform.position;
        //}
        //if (GetComponent<spawnPoints>().point2 == true)
        //{
        //    spawnPos = GetComponent<spawnPoints>().transform.position;
        //}
        //if (GetComponent<spawnPoints>().point3 == true)
        //{
        //    spawnPos = GetComponent<spawnPoints>().transform.position;
        //}
    }

    //spawns player at appropriate spawn site and sets health to max and activates movement and jumping
    void ReLife()
    {
        print("test");

        Destroy(playerClone);

        if (GetComponent<spawnPoints>().point1 == true)
        {
            spawnPos = new Vector3(Spawner1.transform.position.x, Spawner1.transform.position.y + 0.5f, Spawner1.transform.position.z);
            playerClone = Instantiate(player, spawnPos, Quaternion.identity);
        }
        if (GetComponent<spawnPoints>().point2 == true)
        {
            spawnPos = new Vector3(Spawner2.transform.position.x, Spawner2.transform.position.y + 0.5f, Spawner2.transform.position.z);
            playerClone = Instantiate(player, spawnPos, Quaternion.identity);
        }
        if (GetComponent<spawnPoints>().point3 == true)
        {
            spawnPos = new Vector3(Spawner3.transform.position.x, Spawner3.transform.position.y + 0.5f, Spawner3.transform.position.z);
            playerClone = Instantiate(player, spawnPos, Quaternion.identity);
        }
        if (GetComponent<spawnPoints>().point1 == false && GetComponent<spawnPoints>().point2 == false && GetComponent<spawnPoints>().point3 == false)
        {
            playerClone = Instantiate(player, initialSpawn, Quaternion.identity);
        }

        print("test2");


        print("test3");
        player.GetComponent<healthSystem>().respawn();

        print("test4");
        playerRespawn();

        print("test5");
        playerClone.GetComponent<healthSystem>().MasterScript = gameObject.GetComponent<GM>();

        print("test6");
    }
}
