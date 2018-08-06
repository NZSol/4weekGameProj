
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class rotateLight : MonoBehaviour {
    

    public GameObject player;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (gameObject.transform.rotation.z >= 90 && gameObject.transform.rotation.z <= -90)
        {
            player.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (gameObject.transform.rotation.z <= 90 && gameObject.transform.rotation.z >= -90)
        {
            player.GetComponent<SpriteRenderer>().flipX = false;

        }

    }
}