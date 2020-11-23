using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    //gef hraða á bullet
    public float speed = 20f;
    public Rigidbody2D rb;
    //hversu mikið damage bullet gerir
    public int damage = 40;
    void Start()
    {
        rb.velocity = transform.right * speed; 
    }

    //sér hvort bullet hittir óvin
    void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyHealth enemy = collision.GetComponent<EnemyHealth>();
        BossHealth boss = collision.GetComponent<BossHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        if(boss != null)
        {
            boss.TakeDamage(damage);
        }
        
    }


}
