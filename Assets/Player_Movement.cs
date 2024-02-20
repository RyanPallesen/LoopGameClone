using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float playerSpeed = 3;

    public void UpdateInput(Vector2 movement)
    {
        float oldMagnitude = movement.magnitude;
        movement.Normalize();
        
        //Allows for partial press, controllers and getaxis lerping
        movement *= oldMagnitude;

        movement *= playerSpeed;
        movement *= Time.deltaTime;

        transform.position += new Vector3(movement.x, 0, movement.y);
    }
}
