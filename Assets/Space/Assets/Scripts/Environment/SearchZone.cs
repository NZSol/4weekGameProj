using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchZone : MonoBehaviour {

    public bool canSearch = true;
    public bool inRange = false;

    public float searchTimer;

    float timeDelay;
    int item;

    public healthSystem lifeCount;
    public GM MasterScript;

    // Use this for initialization
    void Start () {
        searchTimer = 4;
        timeDelay = Time.deltaTime;
        item = Random.Range(0, 100);





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
            print(item);
            ItemPickup();
        }
    }

    void OnTriggerEnter (Collider col)
    {
        inRange = true;
	}

    void OnTriggerExit(Collider col)
    {
        inRange = false;

        if (searchTimer != 0)
        {
            timerReset();
        }
    }


    void timerReset()
    {
        searchTimer = 5;
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
