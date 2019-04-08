using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{

    Dictionary<Vector2Int,WayPoint> grid = new Dictionary<Vector2Int, WayPoint>();
        
    // Start is called before the first frame update
    void Start()
    {
        LoadBlocks();
    }

    void LoadBlocks()
    {
        var wayPoints = FindObjectsOfType<WayPoint>();
        foreach (WayPoint wayPoint in wayPoints)
        {
            var gridPos = wayPoint.GetGridPos();
            if (grid.ContainsKey(gridPos))
            {
                Debug.Log("Warning Overlapping block " + wayPoint);
            }
            else
            {
                grid.Add(gridPos, wayPoint);
            }
        }
    }
}
