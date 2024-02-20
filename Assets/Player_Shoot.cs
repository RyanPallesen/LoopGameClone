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
    }

    public void TryShoot()
    {
        if (timer > cooldown)
        {
            timer = 0;

            Shoot();
        }
    }

    public void Shoot()
    {

        GameObject instantiatedBullet = Instantiate<GameObject>(bulletPrefab);

        Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit outhit);
        Vector3 target = outhit.point;
        target.y = transform.position.y;

        Vector3 direction = (target - this.transform.position).normalized;

        instantiatedBullet.GetComponent<Rigidbody>().velocity = direction * shotSpeed;
        instantiatedBullet.transform.position = this.transform.position + direction * 1.25f;

    }
}
