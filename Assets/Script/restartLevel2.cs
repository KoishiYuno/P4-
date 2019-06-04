using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartLevel2 : MonoBehaviour
{
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
            SceneManager.LoadScene(4);
            return;
        }

        if (collision.gameObject.transform.parent) {
            Destroy(collision.gameObject.transform.parent.gameObject);
        }
        else{
            Destroy(collision.gameObject);
        }
    }
}
