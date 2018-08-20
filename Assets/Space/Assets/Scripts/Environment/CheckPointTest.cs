using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointTest : MonoBehaviour {

    public Vector3 playerPos;

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "checkPoint")
        {
            playerPos = new Vector3(col.transform.position.x, col.transform.position.y + 0.5f, 0);
            
        }
    }

}
