using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settings_menu : MonoBehaviour
{
    public void SoundButtonOn(string SoundOn)
    {
        AudioListener.volume = 1;
    }

    public void SoundButtonOff(string SoundOff)
    {
        AudioListener.volume = 0;
    }

    public void BackButton(string SettingsBack)
    {
        SceneManager.LoadScene(SettingsBack);
    }
}