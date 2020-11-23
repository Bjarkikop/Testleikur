using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    //gef óvin health
    public int health = 100;
    public GameObject myPrefab;
    //fall sem lætur óvin taka damage
    int count = 0;

    public void TakeDamage(int damage)
    {
        health -= damage;
        count++;
        Instantiate(myPrefab, new Vector3(2.0F, 5 * count, 0), Quaternion.identity);
        
        if (health <= 0)
        {
            Die();
        }
        
        
    }
    //fall sem deletar óvin ef hann health er 0
    void Die()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
