using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	public float JumpHeight;
	private bool Jumping = false;
    public float timer;

    Animator Move;

    private Rigidbody2D _rigidBody2D;

	private void Awake()
	{
		_rigidBody2D = GetComponent<Rigidbody2D>();
	}

    private void Start()
    {
        Move = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update ()
	{
        if (Input.GetKeyDown(KeyCode.W) && !Jumping)
        {
			_rigidBody2D.AddForce(Vector2.up * JumpHeight);

			Jumping = true;
            Move.SetBool("Idle", false);
            Move.SetBool("Land", false);
            timer = 0;
        }

        if (timer == 1)
        {
            Move.SetBool("Idle", true);
        }
    }

	void OnCollisionEnter2D (Collision2D col)
	{
        //col
		if(col.collider.gameObject.tag == "Ground")
		{
            if(Jumping == true)
            {
                Move.SetBool("Land", true);
                timer++;
                Jumping = false;
            }
		}
	}
}
