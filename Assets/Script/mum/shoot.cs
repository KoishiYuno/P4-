using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject slipper;
    public float fireRate; 
    private float nextFire;

    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        checkFire();
    }
    
    void checkFire()
    {
        if(Time.time > nextFire)
        {
            Instantiate(slipper, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
