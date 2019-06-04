using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mumFollow : MonoBehaviour
{
    public GameObject player, mum;
    public float speed;
    private Transform target, currentLocation;

    // Start is called before the first frame update
    void Start()
    {
        //sets target to the players current location
        target = player.GetComponent<Transform>();
        currentLocation = mum.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentLocation != target)
        {
            //moves enemy from current position to the location of the target
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        } else {
            Destroy(player);
        }
    }
}
