using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
  public float Speed;
  public float GravityUp;
  public float GravityDown;

  private SpriteRenderer BIG;

    private void Awake()
    {
        BIG = GetComponent<SpriteRenderer>();
    }

    void Update()
  {
    float xInput = Input.GetAxisRaw("Horizontal");
    float yInput = Input.GetAxisRaw("Vertical");

    if (xInput == 1)
    {
      transform.Translate(Speed, 0, 0);
      BIG.flipX = true;
    }   

    else if (xInput == -1)
    {
      transform.Translate(-Speed, 0, 0);
      BIG.flipX = false;
    }

    if (yInput == 1)
    {
      transform.Translate(0, Speed*GravityUp, 0);
    }
  }
}
