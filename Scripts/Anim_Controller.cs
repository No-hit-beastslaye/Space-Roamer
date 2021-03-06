﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Controller : MonoBehaviour
{

    Animator Move;

    //Getting the Animator.
    void Start()
    {
        Move = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Alle animatie binds.
        if (Input.GetKeyDown(KeyCode.A))
        {
            Move.SetBool("Run", true);
        }

        else if (Input.GetKeyUp(KeyCode.A))
        {
            Move.SetBool("Run", false);
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            Move.SetBool("Run", true);
        }

        else if (Input.GetKeyUp(KeyCode.D))
        {
            Move.SetBool("Run", false);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Move.SetBool("Run", false);
            Move.SetBool("Jump", true);
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                Move.SetBool("Run", true);
            }
        }

        else if (Input.GetKeyUp(KeyCode.W))
        {
            Move.SetBool("Jump", false);
        }
    }
}
