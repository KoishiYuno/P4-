using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsScript : MonoBehaviour
{
    HUBscript hub;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            hub = GameObject.Find("Main Camera").GetComponent<HUBscript>();
            hub.IncreaseScore(10);
            Destroy(this.gameObject);
        }
    }
}
