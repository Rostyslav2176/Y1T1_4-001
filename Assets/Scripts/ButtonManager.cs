using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void NewGameBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void ExitBtn()
    {
        Application.Quit();
    }

    public void MenuLvl()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
