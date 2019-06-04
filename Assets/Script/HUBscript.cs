using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUBscript : MonoBehaviour
{
    float Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score += Time.deltaTime;
    }

    public void IncreaseScore(int x) {
        Score += x;
    }

    public void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)Score * 100);
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int)(Score * 100));
    }
}
