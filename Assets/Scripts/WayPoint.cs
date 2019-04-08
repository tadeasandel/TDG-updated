using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    Vector2Int gridPos;
    const int gridLimit = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int GetGridSize()
    {
        return gridLimit;
    }

    public Vector2Int GetGridPos()
    {
        return new Vector2Int(
            Mathf.RoundToInt(transform.position.x / gridLimit) * gridLimit,
            Mathf.RoundToInt(transform.position.z / gridLimit) * gridLimit
            );
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
