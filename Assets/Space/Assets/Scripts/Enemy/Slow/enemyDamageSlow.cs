using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamageSlow : MonoBehaviour {
    

    private void OnCollisionEnter(Collision col)
    {
        var hit = col.gameObject;
        var health = hit.GetComponent<EnemyHealthSystemSlow>();
        if (health != null)
        {
            health.TakeDamage(10);
        }
    }
}
