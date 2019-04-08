using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour
{
    [Header("Movement")]
    [Range(0f, 100f)] [SerializeField] float xlimit = 10f;
    [Range(0f, 100f)] [SerializeField] float zlimit = 10f;

    TextMesh textMesh;

    private void Start()
    {
    }

    private void Update()
    {
        Vector3 snapPos;

        snapPos.x = Mathf.RoundToInt(transform.position.x / xlimit) * xlimit;
        snapPos.z = Mathf.RoundToInt(transform.position.z / zlimit) * zlimit;
        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);

        textMesh = GetComponentInChildren<TextMesh>();
        string labelText = (snapPos.x / xlimit) + "," + (snapPos.z / zlimit);
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}
