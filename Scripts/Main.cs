using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
  public float Speedweed;
  public float GravityUp;
  public float GravityDown;

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
    }   

    else if (xInput == -1)
    {
      transform.Translate(-Speedweed, 0, 0);
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
