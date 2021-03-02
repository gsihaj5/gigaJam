using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapper : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        if (!Application.isPlaying)
            SnapToGrid();
    }

    private void SnapToGrid()
    {
        var position = transform.position;
        var newPosition = new Vector3(
            Mathf.RoundToInt(position.x),
            Mathf.RoundToInt(position.y),
            Mathf.RoundToInt(position.z)
        );

        transform.position = newPosition;
    }
}