using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testSource : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
		
	}
    
    private void OnTriggerEnter(Collider col)
    {
        var hit = col.gameObject;
        var health = hit.GetComponent<healthSystem>();
        if (health != null)
        {
            health.TakeDamage(50);
        }
    }
}
