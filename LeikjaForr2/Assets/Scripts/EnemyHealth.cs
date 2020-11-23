using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    //gef óvin health
    public int health = 100;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
        
        
    }
    //fall sem deletar óvin ef hann health er 0
    void Die()
    {
        Destroy(gameObject);
    }
}
