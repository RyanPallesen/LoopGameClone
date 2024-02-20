using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DoMovement();
        DoDamage();
    }

    public void DoDamage()
    {
        if(Vector3.Distance(this.transform.position, Player_Inputs.instance.transform.position) < 1f)
        {
            Player_Inputs.instance.GetComponent<HealthComponent>().TakeDamage(25f * Time.deltaTime);
        }
    }

    public void DoMovement()
    {
        Vector3 playerPosition = Player_Inputs.instance.transform.position;
        Vector3 ourPosition = this.transform.position;

        Vector3 direction = (playerPosition - ourPosition).normalized;

        if (Mathf.Abs(playerPosition.x - ourPosition.x) > WorldManager.instance.WorldSize / 2)
            direction.x *= -1f;

        if (Mathf.Abs(playerPosition.z - ourPosition.z) > WorldManager.instance.WorldSize / 2)
            direction.z *= -1f;

        direction.y = 0;

        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}
