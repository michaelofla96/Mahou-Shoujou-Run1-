using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_over_buttons : MonoBehaviour
{
    public void PlayAgainButton(string PlayAgain)
    {
        SceneManager.LoadScene(PlayAgain);
    }

    public void ReturnMenuButton(string MenuReturn)
    {
        SceneManager.LoadScene(MenuReturn);
    }
}
