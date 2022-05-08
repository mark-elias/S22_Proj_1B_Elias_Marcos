using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//include this:
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneManagerScript : MonoBehaviour
{

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");

        PersistentManagerScript.Instance.PERSISTENT_VARIABLE = +1;
    }

    public void GoToPlayGameScene()
    {
        SceneManager.LoadScene("PlayGameScene");

        PersistentManagerScript.Instance.PERSISTENT_VARIABLE = +1;

    }

    public void GoToAboutScene()
    {
        SceneManager.LoadScene("AboutScene");
    }

    public void GoToSettingsScene()
    {
        SceneManager.LoadScene("SettingsScene");
    }

    public void Quit_Application()
    {
        Application.Quit();
    }


}
