using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour
{
    [Range(1f, 20f)]
    public float scrollSpeed = 1f;
    public GameObject player;
    public float scrollOffset;
    Vector2 startPos;
    float newPos;

    private void Start()
    {
        Vector2 playerPos = player.transform.position;
        startPos = playerPos;
    }

    private void Update()
    {
        Vector2 playerPos = player.transform.position;
        //startPos = transform.position;
        newPos = Mathf.Repeat(Time.time * -scrollSpeed, scrollOffset);

        transform.position = startPos + playerPos + Vector2.right * newPos;
    }
}