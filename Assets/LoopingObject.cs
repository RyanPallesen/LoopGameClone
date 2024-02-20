using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LoopingObject : MonoBehaviour
{
    public GameObject falseCopy;
    public UnityEvent<GameObject> OnSpawnFalseCopy;
    // Start is called before the first frame update
    void Start()
    {
        if(!falseCopy)
        {
            //Debug.LogError("Object " + gameObject.name + " did not have falsecopy in LoopingObject");
            return;
        }    

        for (int x = -1; x <= 1; x++)
        {
            for (int z = -1; z <= 1; z++)
            {
                if (x == 0 && z == 0)
                {
                    
                }
                else
                { 
                    GameObject copy = GameObject.Instantiate(falseCopy);
                    copy.transform.SetParent(this.transform);
                    copy.transform.localPosition = new Vector3(WorldManager.instance.WorldSize* x, copy.transform.position.y, WorldManager.instance.WorldSize * z);
                    OnSpawnFalseCopy.Invoke(copy);
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -WorldManager.instance.WorldSize / 2)
            transform.position += new Vector3(WorldManager.instance.WorldSize, 0, 0);

        if (transform.position.x > WorldManager.instance.WorldSize / 2)
            transform.position += new Vector3(-WorldManager.instance.WorldSize, 0, 0);

        if (transform.position.z < -WorldManager.instance.WorldSize / 2)
            transform.position += new Vector3(0, 0, WorldManager.instance.WorldSize);

        if (transform.position.z > WorldManager.instance.WorldSize / 2)
            transform.position += new Vector3(0, 0, -WorldManager.instance.WorldSize);
    }
}
