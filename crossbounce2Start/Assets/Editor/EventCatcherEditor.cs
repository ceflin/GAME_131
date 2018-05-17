using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EventCatcher))]
public class EventCatcherEditor : Editor
{
    private const float MOVE = .5f;
    private const float ROTATE = 1f;

    private void OnSceneGUI()
    {
        EventCatcher eventCatcher = (EventCatcher)target;
        Event currentEvent = Event.current;

        switch (currentEvent.type)
        {
            case EventType.KeyDown:

                if(currentEvent.keyCode == KeyCode.W && !currentEvent.shift)
                {
                    currentEvent.Use();
                    MoveVert(MOVE);
                }
                if (currentEvent.keyCode == KeyCode.S && !currentEvent.shift)
                {
                    currentEvent.Use();
                    MoveVert(-MOVE);
                }
                if (currentEvent.keyCode == KeyCode.A && !currentEvent.shift)
                {
                    currentEvent.Use();
                    MoveHor(-MOVE);
                }
                if (currentEvent.keyCode == KeyCode.D && !currentEvent.shift)
                {
                    currentEvent.Use();
                    MoveHor(MOVE);
                }

                if (currentEvent.keyCode == KeyCode.Q && !currentEvent.shift)
                {
                    currentEvent.Use();
                    RotateObstacle(ROTATE);
                }
                if (currentEvent.keyCode == KeyCode.E && !currentEvent.shift)
                {
                    currentEvent.Use();
                    RotateObstacle(-ROTATE);
                }
                break;
        }


    }

    private void MoveVert(float amount)
    {
        Selection.activeGameObject.transform.Translate(0, amount, 0, Space.World);
    }
    private void MoveHor(float amount)
    {
        Selection.activeGameObject.transform.Translate(amount, 0, 0, Space.World);
    }

    private void RotateObstacle(float amount)
    {
        if (Selection.activeGameObject.GetComponent<MoveBetweenTwoPoints>().enabled)
            Selection.activeGameObject.transform.Rotate(0, 0, amount, Space.Self);
        else
            Selection.activeGameObject.transform.Rotate(0, 0, amount);
    }
}
