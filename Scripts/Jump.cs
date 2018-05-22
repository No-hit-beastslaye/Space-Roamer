using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	public float JumpHeight;
	private bool Jumping = false;

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
        if (Jumping = false)
        {
            Move.SetBool("Land", true);
        }

        if (Input.GetKeyDown(KeyCode.W) && !Jumping || Input.GetKeyDown(KeyCode.Space) && !Jumping)
        {
			_rigidBody2D.AddForce(Vector2.up * JumpHeight);

			Jumping = true;
		}
	}

	void OnCollisionEnter2D (Collision col)
	{
		if(col.gameObject.tag == "Ground")
		{
			Jumping = false;
		}
	}
}
