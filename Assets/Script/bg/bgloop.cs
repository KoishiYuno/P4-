using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgloop : MonoBehaviour
{
    public float speed;
    public float end;
    public float start;
 
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= end)
        {
            Vector2 pos = new Vector2(start, transform.position.y);
            transform.position = pos;
        }
    }
}
