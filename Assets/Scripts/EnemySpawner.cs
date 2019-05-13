using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    [Range(0.1f, 120f)] [SerializeField] float secondsBetweenSpawns = 2f;
    [SerializeField] EnemyMovement enemies;
    [SerializeField] Transform enemyParentTransform;
    [SerializeField] Text scoreText;
    [SerializeField] int scorenumber = 0;
    [SerializeField] AudioClip spawnedEnemySFX;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            var enemy = Instantiate(enemies, transform.position, Quaternion.identity);
            enemy.transform.parent = enemyParentTransform;
            GetComponent<AudioSource>().PlayOneShot(spawnedEnemySFX);
            scorenumber++;
            scoreText.text = scorenumber.ToString();
            yield return new WaitForSeconds(secondsBetweenSpawns);
        }
    }
}
