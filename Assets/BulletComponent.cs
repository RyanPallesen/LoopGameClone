using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    public float lifetime;
    public AnimationCurve bulletSizeOverTime;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > lifetime)
        {
            Destroy(this.gameObject);
        }
        else
        {
            float time = (timer / lifetime);

            this.transform.localScale = Vector3.one * bulletSizeOverTime.Evaluate(time);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        OnCollider(collision.collider);
    }

    public void OnCollider(Collider other)
    {
        HealthComponent hitComponent = other.gameObject.GetComponent<HealthComponent>();
        if (hitComponent)
        {
            hitComponent.OnHit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        OnCollider(other);
    }
}
