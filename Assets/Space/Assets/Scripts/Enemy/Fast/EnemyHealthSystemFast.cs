using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthSystemFast : MonoBehaviour {

    public const int maxHealth = 20;
    public int currentHealth;
    

    // Use this for initialization
    void Start () {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {

        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }

    }
    

}
