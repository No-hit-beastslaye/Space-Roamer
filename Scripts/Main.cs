using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
  public float Speedweed;
  public float GravityUp;
  public float GravityDown;

  private SpriteRenderer BIG;

    private void Awake()
    {
        BIG = GetComponent<SpriteRenderer>();
    }

    void Update()
  {
    /*velocity = velocity + acceleration * Time.deltaTime;
    transform.position = transform.position + velocity * Time.deltaTime;*/

    //transform.Position(new Vector3(0, 0,xInput * -1) * Speed * Time.deltaTime);
    float xInput = Input.GetAxisRaw("Horizontal");
    float yInput = Input.GetAxisRaw("Vertical");

    if (xInput == 1)
    {
      transform.Translate(Speedweed, 0, 0);
      BIG.flipX = true;
    }   

    else if (xInput == -1)
    {
      transform.Translate(-Speedweed, 0, 0);
      BIG.flipX = false;
    }

    if (yInput == 1)
    {
      transform.Translate(0, Speedweed*GravityUp, 0);
    }

    else if (yInput == -1)
    {
      transform.Translate(0, -Speedweed*GravityDown, 0);
    }


    //transform.Position(new Vector3(0, 0,xInput * -1) * Speed * Time.deltaTime);

  }
}
