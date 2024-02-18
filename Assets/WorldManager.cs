using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public static WorldManager instance;
    public float WorldSize;

    // Start is called before the first frame update
    void Start()
    {
        if (!instance)
            instance = this;
        else
        {
            Debug.LogError("Another world manager already exists!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
