using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] obj;
    public float spawnMax = 2f;
    public float spawnMin = 1f;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn() {
        Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        Invoke("spawn", Random.Range(spawnMax,spawnMin));
    }
}
