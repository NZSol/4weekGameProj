using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fastMovement : MonoBehaviour
{
    GameObject Target;
    Transform targetPos;

    public GameObject spawnLocation;
    Vector3 spawnPos;
    Transform spawnSite;

    float distFromTarget;
    float range = 10;
    float movementSpeed = 2;
    float distFromSpawn;
    


    void Awake()
    {
        spawnLocation.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    void Update()
    {
        spawnSite = spawnLocation.transform;
        distFromSpawn = Vector3.Distance(new Vector3(transform.position.x, 0, 0), new Vector3(spawnLocation.transform.position.x, 0, 0));


        Target = GameObject.FindWithTag("player");
        if (Target != null)
        {
            targetPos = Target.transform;
            distFromTarget = Vector3.Distance(new Vector3(transform.position.x, 0, 0), new Vector3(targetPos.position.x, 0, 0));
        }

        //print(spawnSite.transform.position);
        if (distFromTarget < range)
        {
            //print("following");
            pathfind();
        }
        else if (distFromTarget > range)
        {
            //print("returning");
            returnToSite();
        }
    }

    

    void pathfind()
    {
        transform.LookAt(targetPos);
        transform.position += new Vector3(transform.forward.x * movementSpeed * Time.deltaTime, 0, 0);
    }

    public void returnToSite()
    {
        transform.LookAt(spawnSite);
        if (distFromSpawn > 0.1f)
        {
            transform.position += new Vector3(transform.forward.x * movementSpeed * Time.deltaTime, 0, 0);
        }
    }
}
