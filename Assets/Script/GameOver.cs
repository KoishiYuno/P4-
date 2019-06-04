using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    int score = 0;
    private GUIStyle guiStyle = new GUIStyle();

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
    }

    private void OnGUI()
    {
        guiStyle.fontSize = 30;
        guiStyle.normal.textColor = Color.gray;
        GUI.Label(new Rect((Screen.width / 2) - 40, 200, 80, 30), " " + score ,guiStyle);
       
    }

    public void playLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void playLevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
