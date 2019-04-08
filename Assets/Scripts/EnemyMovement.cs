using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<WayPoint> path;

    // Start is called before the first frame update
    void Start()
    {
    }
    IEnumerator FollowPath()
    {
        foreach (WayPoint Waypoint in path)
        {
            transform.position = Waypoint.transform.position;
            yield return new WaitForSeconds(1f);
        }
    }
}
