using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Parts_Collect : MonoBehaviour {

    public int Doel = 0;

    public Component End;

    public Component C0;
    public Component C1;
    public Component C2;
    public Component C3;
    public Component C4;

    private string lv2 = "Level2";
    private string Vic = "Victory";
    
    //Met de collision en de tag kan je de onderdelen verzamelen.
    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.gameObject.CompareTag("Rocket part"))
        {
            Coin.gameObject.SetActive(false);
            Doel++;
        }

        //Als je alle onderdelen hebt, en dan het einde bereikt, win je.
        if (Coin.gameObject.CompareTag("End Point"))
        {
            if (Doel >= 4)
            {
                Debug.Log("Congratulations, you've won the game.");
                End.gameObject.SetActive(true);

                //SceneManager.LoadScene(lv2);
                SceneManager.LoadScene(Vic);
            }
    
            //Als je niet genoeg onderdelen hebt, gebeurd er niks.
            else if (Doel >= 4)
            {
                Debug.Log("Oof, you miss a few parts.");
            }
        }
    }

    //UI deel voor de onderdelen.
    private void Update()
    {
        if (Doel <= 0)
        {
            C0.gameObject.SetActive(true);
            C1.gameObject.SetActive(false);
            C2.gameObject.SetActive(false);
            C3.gameObject.SetActive(false);
            C4.gameObject.SetActive(false);
        }

        if (Doel == 1)
        {
            C0.gameObject.SetActive(false);
            C1.gameObject.SetActive(true);
            C2.gameObject.SetActive(false);
            C3.gameObject.SetActive(false);
            C4.gameObject.SetActive(false);
        }
        
        if (Doel == 2)
        {
            C0.gameObject.SetActive(false);
            C1.gameObject.SetActive(false);
            C2.gameObject.SetActive(true);
            C3.gameObject.SetActive(false);
            C4.gameObject.SetActive(false);
        }

        if (Doel == 3)
        {
            C0.gameObject.SetActive(false);
            C1.gameObject.SetActive(false);
            C2.gameObject.SetActive(false);
            C3.gameObject.SetActive(true);
            C4.gameObject.SetActive(false);
        }

        if (Doel >= 4)
        {
            C0.gameObject.SetActive(false);
            C1.gameObject.SetActive(false);
            C2.gameObject.SetActive(false);
            C3.gameObject.SetActive(false);
            C4.gameObject.SetActive(true);
        }
    }
}

