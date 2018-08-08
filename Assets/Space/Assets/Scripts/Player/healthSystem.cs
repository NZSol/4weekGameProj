using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthSystem : MonoBehaviour {

    public const int maxHealth = 100;
    public int currentHealth;
    float timeDelay;
    float InvokeDelay = 10;

    public GameObject player;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public

    Vector3 spawnPos;

    GameObject playerClone;

    private void Awake()
    {
    }

    // Use this for initialization
    void Start () {
        currentHealth = maxHealth;
        InvokeDelay = timeDelay * Time.deltaTime;
    }

    // Update is called once per frame
    void Update () {
        //print(currentHealth);
        print(player.GetComponentInChildren<jumpSwitch>().canJump);
	}

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            player.GetComponent<movement>().canMove = false;
            player.GetComponentInChildren<jumpSwitch>().canJump = false;


            Invoke("ReLife", timeDelay);
        }

    }


    //Check for specific spawning point player is at and sets values to spawnPos vector
    void checkSpawn()
    {
        if (player.GetComponent<spawnPoints>().point1 == true)
        {
            spawnPos = player.GetComponent<spawnPoints>().transform.position;
        }
        if (player.GetComponent<spawnPoints>().point2 == true)
        {
            spawnPos = player.GetComponent<spawnPoints>().transform.position;
        }
        if (player.GetComponent<spawnPoints>().point3 == true)
        {
            spawnPos = player.GetComponent<spawnPoints>().transform.position;
        }
    }

    //spawns player at appropriate spawn site and sets health to max and activates movement and jumping
    void ReLife()
    {
        if (player.GetComponent<spawnPoints>().point1 == true)
        {
            playerClone = Instantiate(player, spawnPos, Quaternion.identity);
        }
        if (player.GetComponent<spawnPoints>().point2 == true)
        {
            playerClone = Instantiate(player, spawnPos, Quaternion.identity);
        }
        if (player.GetComponent<spawnPoints>().point3 == true)
        {
            playerClone = Instantiate(player, spawnPos, Quaternion.identity);
        }


        playerClone = Instantiate(player, transform.position, Quaternion.identity) as GameObject;
        currentHealth = maxHealth;
        player.GetComponent<movement>().canMove = true;
        player.GetComponentInChildren<jumpSwitch>().canJump = true;
    }
    
}
