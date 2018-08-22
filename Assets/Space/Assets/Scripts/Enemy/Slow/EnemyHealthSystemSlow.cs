using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthSystemSlow : MonoBehaviour
{

    public const int maxHealth = 10;
    public int currentHealth;


    // Use this for initialization
    void Start()
    {
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
