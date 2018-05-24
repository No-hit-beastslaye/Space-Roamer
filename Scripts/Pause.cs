using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject Pausemenu, PauseButton;

	public void PauseHard()
    {
        Pausemenu.SetActive(true);
        
        Time.timeScale = 0;
    }
	
	
	public void Resume()
    {
        Pausemenu.SetActive(false);
        
        Time.timeScale = 1;
    }
}
