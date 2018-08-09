using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnPoints : MonoBehaviour {

    
    public bool point1 = false;
    public bool point2 = false;
    public bool point3 = false;




    public void spawn1()
    {
        point1 = true;
        point2 = false;
        point3 = false;
    }

    public void spawn2()
    {
        point1 = false;
        point2 = true;
        point3 = false;

    }

    public void spawn3()
    {
        point1 = false;
        point2 = false;
        point3 = true;

    }
}
