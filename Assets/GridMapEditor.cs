using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GridMapEditor : MonoBehaviour
{
    [SerializeField] private Vector2Int mapSize;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;

        for (int x = 0; x < mapSize.x; x++)
        {
            for (int y = 0; y < mapSize.y; y++)
            {
                Vector3 lineEnd = new Vector3(x, 0, y);
                Gizmos.DrawLine(new Vector3(0,0,y), lineEnd);
                Gizmos.DrawLine(new Vector3(x,0,0), lineEnd);
            }
        }
    }

    private void Update()
    {
        //GL.
    }

    public Vector2Int GetHalfSize()
    {
        return mapSize / 2;
    }
}
