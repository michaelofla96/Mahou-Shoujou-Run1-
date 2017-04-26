using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_buttons : MonoBehaviour
{
    public void NewGameButton(string GameStart)
    {
        SceneManager.LoadScene(GameStart);
    }

    public void SettingsGameButton(string MenuSettings)
    {
        SceneManager.LoadScene(MenuSettings);
    }

    public void HelpButton(string HelpSettings)
    {
        SceneManager.LoadScene(HelpSettings);
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }

}