using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float movementPeriod = 0.00001f;
    [SerializeField] ParticleSystem deathParticles;
    Vector2Int fromBottom = new Vector2Int(0, 1);
    Vector2Int fromTop = new Vector2Int(0, -1);
    Vector2Int fromLeft = new Vector2Int(1, 0);
    Vector2Int fromRight = new Vector2Int(-1, 0);
    [SerializeField]public float movingFactor = 10f;
   // string right = "right", left = "left", up = "up", down = "down";
    [SerializeField]public float movementSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        PathFinder pathfinder = FindObjectOfType<PathFinder>();
        var path = pathfinder.GetPath();
        StartCoroutine(FollowPath(path));
    }
    IEnumerator FollowPath(List<WayPoint> path)
    {
        foreach (WayPoint Waypoint in path)
        {

                    if (Waypoint.directionFrom == fromBottom)
                    {
                for (int i = 0; i < 10; i++)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + movingFactor);
                    yield return new WaitForSeconds(movementPeriod);
                }
            }
                    if (Waypoint.directionFrom == fromTop)
                    {
                for (int i = 0; i < 10; i++)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - movingFactor);
                    yield return new WaitForSeconds(movementPeriod);
                }
            }
                    if (Waypoint.directionFrom == fromLeft)
                    {
                for (int i = 0; i < 10; i++)
                {
                    transform.position = new Vector3(transform.position.x + movingFactor, transform.position.y, transform.position.z);
                    yield return new WaitForSeconds(movementPeriod);
                }
            }
                    if (Waypoint.directionFrom == fromRight)
                    {
                for (int i = 0; i < 10; i++)
                {
                    transform.position = new Vector3(transform.position.x - movingFactor, transform.position.y, transform.position.z);
                    yield return new WaitForSeconds(movementPeriod);
                }
            }
        }
        SelfDestruct();
    }

    private void SelfDestruct()
    {
        var vfx = Instantiate(deathParticles, transform.position, Quaternion.identity);
        vfx.Play();
        Destroy(vfx.gameObject, vfx.main.duration);
        Destroy(gameObject);
    }
}
