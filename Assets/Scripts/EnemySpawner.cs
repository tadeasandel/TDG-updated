using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float secondsBetweenSpawns = 10f;
    [SerializeField] GameObject enemies;
    [SerializeField] int numberOfEnemies = 10;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        if (numberOfEnemies == 0) {yield return null; }
        else
        {
            enemies = new GameObject();
            numberOfEnemies--;
            yield return new WaitForSeconds(secondsBetweenSpawns);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
