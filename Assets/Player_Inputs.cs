using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player_Movement))]
public class Player_Inputs : MonoBehaviour
{
    Player_Movement movement;
    // Start is called before the first frame update
    void Start()
    {
        if (!movement)
        {
            movement = GetComponent<Player_Movement>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        movement.UpdateInput(moveVector);
    }
}
