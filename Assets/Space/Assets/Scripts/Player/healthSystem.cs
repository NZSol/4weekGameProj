using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthSystem : MonoBehaviour {

    public const int maxHealth = 100;
    public int currentHealth;
    float timeDelay;
    float InvokeDelay = 10;

    public GameObject player;
    public GameObject deathOptions;

    GameObject playerClone;
    

	// Use this for initialization
	void Start () {
        deathOptions.SetActive(false);
        currentHealth = maxHealth;
        InvokeDelay = timeDelay * Time.deltaTime;
    }

    void Setup()
    {
        playerClone = Instantiate(player, transform.position, Quaternion.identity) as GameObject;
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
            deathOptions.SetActive(true);
            player.GetComponent<movement>().canMove = false;
            player.GetComponentInChildren<jumpSwitch>().canJump = false;

            Invoke("ReLife", timeDelay);
        }

    }


    void ReLife()
    {
        playerClone = Instantiate(player, transform.position, Quaternion.identity) as GameObject;
    }
    
}
