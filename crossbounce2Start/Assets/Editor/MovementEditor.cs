using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MoveBetweenTwoPoints))]
public class MovementEditor : Editor {

    private void OnDrawGizmos()
    {
        //Gizmos.color = Color.green;
        //Gizmos.DrawLine(MoveBetweenTwoPoints.transform.position, startPosition);
        //Gizmos.DrawLine(transform.position, endPosition);
    }

    private void OnSceneGUI()
    {
        
    }
}
