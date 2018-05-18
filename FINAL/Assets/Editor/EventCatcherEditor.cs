using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EventCatcherEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
    }

    private void print(object message)
    {
        UnityEngine.MonoBehaviour.print(message);
    }

    private void OnSceneGUI()
    {
        Event currentEvent = Event.current;

        //switch (currentEvent.type)
        //{
        //    case EventType.KeyDown:
        //        if (currentEvent.keyCode == KeyCode.E)
        //        {
        //            UnityEngine.MonoBehaviour.print("Mouse Position: " + Event.current.mousePosition);
        //        }
        //        break;
        //}

        if (currentEvent.type == EventType.KeyDown)
        {
            if (currentEvent.keyCode == KeyCode.E)
            {
                //Ray worldRay = HandleUtility.GUIPointToWorldRay(currentEvent.mousePosition);
                //RaycastHit hitInfo;

                //if (Physics.Raycast(worldRay,out hitInfo))
                //{
                //    currentEvent.Use();
                //    print("mouse pos: " + hitInfo);
                //}
                //currentEvent.Use();
                Vector2 mousePos = Event.current.mousePosition;
                mousePos.y = Camera.current.pixelHeight - mousePos.y;
                Vector3 pos = Camera.current.ScreenToWorldPoint(currentEvent.mousePosition);
                UnityEngine.MonoBehaviour.print(pos);
            }
        }
    }
}
