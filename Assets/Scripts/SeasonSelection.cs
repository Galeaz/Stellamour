using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeasonSelection : MonoBehaviour
{
    public GameObject Spring_Button;

    public void PlaySpring()
    {
        SceneManager.LoadScene("Game");
    }
}
