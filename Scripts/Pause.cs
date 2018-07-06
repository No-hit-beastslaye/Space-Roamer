
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject Pausemenu, PauseButton;
    public GameObject Player;

    public bool Active = (false);

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseHard();
        }

        else if(Input.GetKeyDown(KeyCode.Escape) && Active == true)
        {
            Resume();
        }
    }

    public void PauseHard()
    {
        Pausemenu.SetActive(true);
        Player.GetComponent<Main>().enabled = false;
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Active = true;
        }
            Time.timeScale = 0;
    }


    public void Resume()
    {
        Pausemenu.SetActive(false);
        Player.GetComponent<Main>().enabled = true;
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Active = false;
        }
            Time.timeScale = 1;
    }
}