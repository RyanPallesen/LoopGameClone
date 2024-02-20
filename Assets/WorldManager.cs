using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public AnimationCurve spawningCurve;
    public float curveSampleSpeed;

    public static WorldManager instance;
    public float WorldSize;
    private float timeSinceBegin = 0;
    private float credits = 0;

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
        timeSinceBegin += Time.deltaTime;
        credits += Time.deltaTime;

        float currentCost = spawningCurve.Evaluate(timeSinceBegin * curveSampleSpeed);
        currentCost /= 1 + (timeSinceBegin / 120f);

        if (credits > currentCost)
        {
            credits -= currentCost;

            SpawnEnemy();
        }
    }

    public void SpawnEnemy()
    {
        Vector3 position = new Vector3(Random.Range(-16, 16), 0, Random.Range(-16, 16));

        GameObject instantiatedObject = Instantiate<GameObject>(enemyPrefab);
        enemyPrefab.transform.position = position;


    }
}
