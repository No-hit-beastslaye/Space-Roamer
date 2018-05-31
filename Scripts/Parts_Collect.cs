using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parts_Collect : MonoBehaviour {

    public int Doel = 0;

    public Component yeet;

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.gameObject.CompareTag("Rocket part"))
        {
            Coin.gameObject.SetActive(false);
            Doel++;
        }


        if (Coin.gameObject.CompareTag("End Point"))
        {
            if (Doel >= 6)
            {
                Debug.Log("Congratulations, you've won the game.");
                Doel++;
                if (Coin.gameObject.CompareTag("End Text"))
                {
                    Coin.gameObject.SetActive(true);
                }
            }

            else if (Doel >= 5)
            {
                Debug.Log("Oof, you miss a few parts.");
            }
        }
    }

    private void Update()
    {
        
    }
}

