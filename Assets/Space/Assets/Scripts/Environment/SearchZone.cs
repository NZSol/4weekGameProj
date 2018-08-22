using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchZone : MonoBehaviour {

    public bool canSearch = true;
    public bool inRange = false;
    bool itemSpawned = false;
    bool textOn;

    public float searchTimer;

    float timeDelay;
    int item;

    public Text searchText;

    public healthSystem lifeCount;
    public GM MasterScript;

    // Use this for initialization
    void Start () {
        searchTimer = 4;
        timeDelay = Time.deltaTime;
        item = Random.Range(0, 100);
        textOn = false;
    }


    private void Update()
    {
        if (canSearch == true && inRange == true && Input.GetKey(KeyCode.E))
        {
            searchTimer -= timeDelay;

        }

        if (Input.GetKeyUp(KeyCode.E) && searchTimer != 0)
        {
            timerReset();
        }

        if (searchTimer <= 0)
        {
            canSearch = false;
            searchTimer = 0;
            spawnItem();
            itemSpawned = true;
        }

        if (inRange == true)
        {
            searchText.gameObject.SetActive(true);
        }
        else
        {
            searchText.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "player")
        {
            inRange = true;
        }
	}

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "player")
        {
            inRange = false;

            if (searchTimer != 0)
            {
                timerReset();
            }
        }
    }
    

    void timerReset()
    {
        searchTimer = 5;
    }

    void spawnItem()
    {
        if (searchTimer == 0 && itemSpawned == false)
        {
            print(item);
            ItemPickup();
            gameObject.GetComponent<Renderer>().enabled = false;
            inRange = false;
        }
    }

    void ItemPickup()
    {

        GameObject player = GameObject.FindGameObjectWithTag("player");


        if (player.GetComponent<healthSystem>().currentHealth > 25)
        {
            if (item  <= 40)
            {
                print("givinghealth");
                MasterScript.giveHealth();
            }
            if (item > 40 && item < 70)
            {
                print("givingAmmo");
                MasterScript.giveAmmo();
            }
            if (item >= 70)
            {
                print("givingNothing");

            }
        }
        else
        {
            if (item <= 60)
            {
                print("givinghealth");
                MasterScript.giveHealth();
            }
            if (item > 60 && item < 80)
            {
                print("givingAmmo");
                MasterScript.giveAmmo();
            }
            if (item >= 80)
            {
                print("givingNothing");
            }
        } 
        print("LocationSearched");
    }
}
