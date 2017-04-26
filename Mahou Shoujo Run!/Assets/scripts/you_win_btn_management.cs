using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class you_win_btn_management : MonoBehaviour {

    public void PlayAgainButton(string PlayAgain)
    {
        SceneManager.LoadScene(PlayAgain);
    }

    public void ReturnMenuButton(string MenuReturn)
    {
        SceneManager.LoadScene(MenuReturn);
    }
}
