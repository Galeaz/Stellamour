using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //singleton
    public static MainMenu MM_instance;
    public GameObject playDemo_Button;
    public GameObject credits_Button;
    public GameObject quit_Button;
    private void Awake()
    {
        MM_instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true); //activates menu
    }

    public void PlayDemo()
    {
        SceneManager.LoadScene("Game"); //loads singleplayer game scene
    }

    public void QuitGame()
    {
        Application.Quit(); //closes game
    }
}
