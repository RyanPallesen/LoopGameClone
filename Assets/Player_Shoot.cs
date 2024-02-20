using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shotSpeed;
    public float cooldown;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(Input.GetMouseButtonDown(0))
        {
            if(timer > cooldown)
            {
                timer = 0;

                GameObject instantiatedBullet = Instantiate<GameObject>(bulletPrefab);
                instantiatedBullet.transform.position = this.transform.position;

                Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit outhit);
                Vector3 target = outhit.point;
                target.y = transform.position.y;

                instantiatedBullet.GetComponent<Rigidbody>().velocity = (target - this.transform.position).normalized * shotSpeed;
            }
        }
    }
}
