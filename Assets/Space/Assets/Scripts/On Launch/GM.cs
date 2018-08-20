using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{

    GameObject playerClone;
    public Vector3 spawnPos;
    Vector3 initialSpawn;

    public screenFade canvas;
    public keyCardPickup[] kcp;

    public GameObject player;
    public GameObject CanvasGroup;
    public GameObject Spawner1;
    public GameObject Spawner2;
    public GameObject Spawner3;


    public healthSystem healthMeter;

    // Use this for initialization
    void Start()
    {
        playerClone = Instantiate(player, initialSpawn, Quaternion.identity) as GameObject;
        playerClone.GetComponent<healthSystem>().MasterScript = gameObject.GetComponent<GM>();
        initialSpawn = new Vector3(-2, 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerClone != null)
        {
            spawnPos = playerClone.GetComponent<CheckPointTest>().playerPos;
        }
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
        Invoke("ReLife", 3);
        Destroy(playerClone);
    }

    //spawns player at appropriate spawn site and sets health to max and activates movement and jumping
    void ReLife()
    {
        if (spawnPos != new Vector3(0,0,0))
        {
            playerClone = Instantiate(player, spawnPos, Quaternion.identity);
        }
        else
        {
            playerClone = Instantiate(player, initialSpawn, Quaternion.identity);
        }


        player.GetComponent<healthSystem>().respawn();
        
        playerRespawn();
        
        playerClone.GetComponent<healthSystem>().MasterScript = gameObject.GetComponent<GM>();
        
    }








    public GameObject ammo;
    public GameObject health;

    public GameObject ammoClone;
    public GameObject healthClone;

    weapon weaponScript;

    
    public void giveAmmo()
    {
        ammoClone = Instantiate(ammo, new Vector3 (playerClone.transform.position.x, playerClone.transform.position.y - 0.25f, playerClone.transform.position.z), Quaternion.identity);
        //makeVisible();
    }

    public void increaseAmmo()
    {
        {
            playerClone.GetComponent<weapon>().ammoCount++;
            Destroy(ammoClone);
        }
    }

    public void giveHealth()
    {
        healthClone = Instantiate(health, new Vector3(playerClone.transform.position.x, playerClone.transform.position.y - 0.25f, playerClone.transform.position.z), Quaternion.identity);
        //makeVisible();
    }

    public void makeVisible()
    {
        if (healthClone != null)
        {
            healthClone.SetActive(true);
        }

        if (ammoClone != null)
        {
            ammoClone.SetActive(true);
        }

    }

}
