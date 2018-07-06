
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject Pausemenu, PauseButton;
    public GameObject Player;

    public bool Active = (false);
    
    //Door input worden er functies aangeroepen.
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

    //Zet het spel op pauze..
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

    //Zorgt ervoor dat het spel kan hervatten.
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
