using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    //breytur fyrir health
    public int maxHealth = 100;
    public int currentHealth;
    public Healthbar healthbar;
    // fallið lætur maxhealth á leikmann æi byrjun
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // ef óvinur snertir leikmann tekur hann damage
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamage(20);
            Debug.Log("Current Health: " + currentHealth);
        }
        
    }
    //fall sem lætur leikmann fá damage
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
        if (currentHealth <= 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
