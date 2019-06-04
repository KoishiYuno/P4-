using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slipper : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public int damage = 20;

    void Start()
    {
        //moves right according to speed
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health player = collision.GetComponent<Health>();
        //if the bullet hits the player he will get damaged
        if (player != null)
        {
            player.getDamaged(damage);
        }
        //destroys the slipper after firing
        //Destroy(gameObject);

    }

}
