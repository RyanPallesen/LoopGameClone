using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMoveDirection : MonoBehaviour
{
    Vector3 lastPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(this.transform.position + (this.transform.position - lastPosition));
        lastPosition = this.transform.position;
    }
}
