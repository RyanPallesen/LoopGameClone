using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    float playerSpeed = 4;

    public void UpdateInput(Vector2 movement)
    {
        movement *= playerSpeed;
        movement *= Time.deltaTime;

        transform.position += new Vector3(movement.x, 0, movement.y);
    }
}
