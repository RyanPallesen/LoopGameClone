using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    public float lifetime;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
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

            this.transform.localScale = Vector3.Lerp(Vector3.one / 0.25f, Vector3.zero, time);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
