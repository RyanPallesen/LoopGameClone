using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player_Movement))]
[RequireComponent(typeof(Player_Shoot))]
public class Player_Inputs : MonoBehaviour
{
    Player_Movement movement;
    Player_Shoot shoot;

    public static Player_Inputs instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        if (!movement)
        {
            movement = GetComponent<Player_Movement>();
        }

        if (!shoot)
        {
            shoot = GetComponent<Player_Shoot>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        movement.UpdateInput(moveVector);

        if (Input.GetMouseButtonDown(0))
        {
            shoot.TryShoot();
        }
    }
}
