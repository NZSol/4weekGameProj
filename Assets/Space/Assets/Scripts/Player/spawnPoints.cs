using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnPoints : MonoBehaviour {
    

    public bool point1 = false;
    public bool point2 = false;
    public bool point3 = false;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
    {

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "spawn1")
        {
            Debug.Log("detected");
            spawn1();
        }

        if (col.gameObject.tag == "spawn2")
        {
            spawn2();
        }

        if (col.gameObject.tag == "spawn3")
        {
            spawn3();
        }
    }

    void spawn1()
    {
        point1 = true;
        point2 = false;
        point3 = false;
    }

    void spawn2()
    {
        point1 = false;
        point2 = true;
        point3 = false;

    }

    void spawn3()
    {
        point1 = false;
        point2 = false;
        point3 = true;

    }
}
