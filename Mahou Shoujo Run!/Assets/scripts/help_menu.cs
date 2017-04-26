using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class help_menu : MonoBehaviour
{
    public void BackButton(string SettingsBack)
    {
        SceneManager.LoadScene(SettingsBack);
    }
}
