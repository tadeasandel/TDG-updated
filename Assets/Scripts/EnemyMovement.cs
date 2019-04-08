using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<WayPoint> path;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FollowPath());
        print("Hey I am at the start again");
    }
    IEnumerator FollowPath()
    {
        print("Starting patrol");
        foreach (WayPoint Waypoint in path)
        {
            transform.position = Waypoint.transform.position;
            print(transform.position);
            yield return new WaitForSeconds(1f);
        }
        print("Ending patrol");
    }
}
