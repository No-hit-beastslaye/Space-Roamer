using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

    private string Deadend = "Game Over";

    private bool GameOver = false;
    public float Life;

    Animator Move;

    public Component hp3;
    public Component hp2;
    public Component hp1;
    public Component hp0;

    public void Start()
    {
        Move = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemie")
        {
            Life--;
            //Move.SetBool("Hit", true);
        }
    }

    private void straight()
    {
        //Move.SetBool("Hit", false);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if ( col.gameObject.tag == "World Border")
        {
            Life = 0;
        }
    }

    void Update()
    {
        if(Life >= 4)
        {
            Life = 3;
        }

        else if(Life == 3)
        {
            hp0.gameObject.SetActive(false);
            hp1.gameObject.SetActive(false);
            hp2.gameObject.SetActive(false);
            hp3.gameObject.SetActive(true);
        }

        else if(Life == 2)
        {
            hp0.gameObject.SetActive(false);
            hp1.gameObject.SetActive(false);
            hp2.gameObject.SetActive(true);
            hp3.gameObject.SetActive(false);
        }

        else if(Life == 1)
        {
            hp0.gameObject.SetActive(false);
            hp1.gameObject.SetActive(true);
            hp2.gameObject.SetActive(false);
            hp3.gameObject.SetActive(false);
        }

        if(Life <= 0)
        {
            hp0.gameObject.SetActive(true);
            hp1.gameObject.SetActive(false);
            hp2.gameObject.SetActive(false);
            hp3.gameObject.SetActive(false);
            Move.SetBool("Death", true);
            GameOver = true;
            GetComponent<Main>().enabled = false;
            
        }

        if(GameOver == true)
        {
            Move.SetBool("Idle", true);
            Move.SetBool("Jump", false);
            Move.SetBool("Land", true);
            Move.SetBool("Run", false);
            Move.SetBool("GameOver", true);
            Move.SetBool("GameOver", true);
        }
    }

    public void AnimationEnded()
    {
        SceneManager.LoadScene(Deadend);
    }
}
