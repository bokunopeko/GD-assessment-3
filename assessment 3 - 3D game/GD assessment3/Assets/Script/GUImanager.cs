using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GUImanager : MonoBehaviour
{
    public GameObject pauseMenu;
    private void Start()
    {
        //pauseMenu.SetActive(false);
    }

    public void NextScene()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainScreen");
    }

    public void ReturnToGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    private void Update()
    {
        if ( Input .GetKey(KeyCode.Escape) )
        {
            //pause the game 
            Time.timeScale = 0f;

           pauseMenu.SetActive(true);
            //setactive pause screen

           
        }
    }



}
