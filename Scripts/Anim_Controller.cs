using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Controller : MonoBehaviour {

    Animator Move;

	void Start ()
	{
		Move = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			Move.SetBool("Run", true);
		}

		else if(Input.GetKeyUp(KeyCode.A))
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
			Move.SetBool("Jump", true);
		}

		else if (Input.GetKeyUp	(KeyCode.W))
		{
			Move.SetBool("Jump", false);
		}
	}
}
