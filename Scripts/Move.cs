using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move: MonoBehaviour {

     private Rigidbody2D myRigidbody;
     private bool facingRight;
     private bool isGrounded;
     private bool jump;

    [SerializeField]
     private LayerMask whatIsGround;

    [SerializeField]
     private float jumpForce;

    [SerializeField]
     private float movementSpeed;

    [SerializeField]
     private Transform[] groundPoints;

    [SerializeField]
     private float groundRadius;

void Start()
  {
    
    myRigidbody = GetComponent<Rigidbody2D>();

  }


void FixedUpdate()
  {
    
    float horizontal = Input.GetAxis("Horizontal");
        isGrounded = IsGrounded();
    HandleMovement(horizontal);

        HandleInput();
  }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            jump = true;
            Debug.Log("111");
        }
    }

    private bool IsGrounded()
    {
        if (myRigidbody.velocity.y <= 0)
        {
            foreach (Transform point in groundPoints)
            {
                Collider2D[] coliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatIsGround);

                for (int i = 0; i < coliders.Length; i++)
                {
                    if (coliders[i].gameObject != gameObject)
                    {

                        return true;

                    }

                }


            }


        }

        return false;


    }

    private void HandleMovement(float horizontal)
  {

    myRigidbody.velocity = new Vector2(horizontal * movementSpeed, myRigidbody.velocity.y);

        if (isGrounded == true && jump == true)
        {
            
            myRigidbody.AddForce(new Vector2(0, jumpForce));
            isGrounded = false;
            jump = false;
            Debug.Log("111");
        }
  }

}
