using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public Button pauseButton;
    public GameObject pauseMenuUI;
    //public bool click;

    private void Start()
    {
        pauseButton.onClick.AddListener(Update);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }
       
 
    public void resume()
    {
        //'turns off'/hides the menu interface
        pauseMenuUI.SetActive(false);
        //sets time back to normal speed
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void pause()
    {
        //enables the pause menu to be accessible
        pauseMenuUI.SetActive(true);
        //Freezes in game time so the player doesn't continue running in the background while the menu is open
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }


}
