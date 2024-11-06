using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class redBox : MonoBehaviour
{
    public Rigidbody2D redBoxRidgidBody;
    public float acceleration;

    private void Start()
    {
      
    }
    private void FixedUpdate()
    {
       // redBoxRidgidBody velocity += (Vector2)(acceleration)
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("We have entered the space of another collider");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("We are currently the space of another collider");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("We have exited the space of another collider");
    }


}
