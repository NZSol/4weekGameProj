
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class rotateLight : MonoBehaviour {
    

    public GameObject player;
    public Vector3 dir;
    public float angle;

    public bool charFlipper;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        
        if (angle >= 90 || angle <= -90)
        {
            player.GetComponent<SpriteRenderer>().flipX = false;
        }

        else
        {
            player.GetComponent<SpriteRenderer>().flipX = true;
        }

    }
    
}