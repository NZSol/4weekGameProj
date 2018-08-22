using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamageFast : MonoBehaviour {
    

    private void OnCollisionEnter(Collision col)
    {
        var hit = col.gameObject;
        var health = hit.GetComponent<EnemyHealthSystemFast>();
        if (health != null)
        {
            health.TakeDamage(10);
        }
    }
}
