using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
[RequireComponent(typeof(WayPoint))]
public class CubeEditor : MonoBehaviour
{
    [Header("Movement")]

    Vector3 gridPos;
    WayPoint wayPoint;

    private void Awake()
    {
        wayPoint = GetComponent<WayPoint>();
    }

    private void Update()
    {
        SnapToGrid();
        UpdateLabel();
    }

    private void SnapToGrid()
    {
        int gridLimit = wayPoint.GetGridSize();
        transform.position = new Vector3(
            wayPoint.GetGridPos().x,
            0f,
            wayPoint.GetGridPos().y
            );
    }

    private void UpdateLabel()
    {
        int gridLimit = wayPoint.GetGridSize();
        TextMesh textMesh = GetComponentInChildren<TextMesh>();
        string labelText = wayPoint.GetGridPos().x / gridLimit + "," + wayPoint.GetGridPos().y / gridLimit;
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}
