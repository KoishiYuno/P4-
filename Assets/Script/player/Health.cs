using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int healthBar = 100;
    public GameObject player;

    public void getDamaged (int damage)
    {
        healthBar -= damage;
        
        if(healthBar <= 0 )
        {
            Die();
        }
    }
    
    void Die()
    {
        Destroy(player);
        SceneManager.LoadScene(4);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
