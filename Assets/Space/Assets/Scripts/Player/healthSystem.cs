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
    public GM MasterScript;

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
    void Update ()
    {
        
	}

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            player.GetComponent<movement>().canMove = false;
            player.GetComponentInChildren<jumpSwitch>().canJump = false;

            MasterScript.checkDeath();
            
        }

    }

    public void respawn()
    {
        currentHealth = maxHealth;
        player.GetComponent<movement>().canMove = true;
        player.GetComponentInChildren<jumpSwitch>().canJump = true;
    }

}
