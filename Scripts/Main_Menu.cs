using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    string Menu = "Main Menu";
    string lv1 = "Space Roamer";
    string lv2 = "Level2";

    //Transition naar het main menu.
    public void LoadMenu()
    {
        SceneManager.LoadScene(Menu);
        Debug.Log("Aighty tighty.");
    }

    //transitie naar het eerste level.
    public void LoadLvl1()
    {
        SceneManager.LoadScene(lv1);
        Debug.Log("YEEET");
    }

    //Closes the game.
    public void Close()
    {
        Application.Quit();
        Debug.Log("Oof");
    }
}
