using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //singleton
    public static PauseMenu PM_instance;

    public GameObject pause_Button;
    public GameObject Resume_Button;
    public GameObject mainMenu_Button;
    public GameObject quit_Button;
    private void Awake()
    {
        PM_instance = this;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Application.Quit(); //closes game
    }
}
