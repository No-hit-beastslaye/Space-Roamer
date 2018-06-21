using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fliping : MonoBehaviour {

    private bool facingRight;
    private SpriteRenderer Charac;

    private void Awake()
    {
        Charac = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {

        float horizontal = Input.GetAxis("Horizontal");
        
        Flip(horizontal);
    }

    private void Flip(float horizontal)
    {

        if (horizontal < 0 && !facingRight || horizontal > 0 && facingRight)
        {
            /** facingRight = !facingRight;

             Vector3 theScale = transform.localScale;

             theScale.x *= -1;

             transform.localScale = theScale;
             **/

            Charac.flipX = false;

        }

        else if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            Charac.flipX = true;
        }

    }
}
