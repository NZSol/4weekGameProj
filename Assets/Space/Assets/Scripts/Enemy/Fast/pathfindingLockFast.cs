using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathfindingLockFast : MonoBehaviour
{

    public GameObject pathfinder;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = pathfinder.transform.position;

        if (pathfinder.transform.rotation.y > 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (pathfinder.transform.rotation.y < 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
