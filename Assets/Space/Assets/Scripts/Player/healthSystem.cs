using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthSystem : MonoBehaviour {

    public const int maxHealth = 100;
    public int currentHealth;

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
    }

    // Update is called once per frame
    void Update ()
    {
        if (currentHealth > 100)
        {
            currentHealth = 100;
        }
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

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "health" && Input.GetKeyDown(KeyCode.E))
        {
            currentHealth += 20;
            Destroy(MasterScript.healthClone);
        }
        if (col.tag == "ammo" && Input.GetKey(KeyCode.E))
        {
            MasterScript.increaseAmmo();
            Destroy(MasterScript.ammoClone);
        }
    }

}
