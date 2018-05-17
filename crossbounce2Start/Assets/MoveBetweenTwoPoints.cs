using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBetweenTwoPoints : MonoBehaviour
{
    public GameObject start;
    public GameObject end;
    public Vector3 startPosition;
    public Vector3 endPosition;
    public bool isMovingToStart = true;
    public float speed = 4.0f;

    public bool isRunning = false;

    // Use this for initialization
    void Start()
    {
        startPosition = start.transform.position;
        endPosition = end.transform.position;
        isRunning = true;
        if (isRunning)
        {
            start.GetComponent<Renderer>().enabled = false;
            end.GetComponent<Renderer>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        float moveMagnitude = speed * Time.deltaTime;
        if (startPosition != endPosition)
        {
            while (moveMagnitude > 0)
            {
                moveMagnitude = ResolveMovement(moveMagnitude);
            }
        }

    }

    private float ResolveMovement(float moveMagnitude)
    {
        Vector3 currentTarget = isMovingToStart ? startPosition : endPosition;
        Vector3 toCurrentTarget = currentTarget - transform.position;
        float targetDelta = Vector3.Distance(currentTarget, transform.position);
        if (moveMagnitude < targetDelta)
        {
            transform.position += toCurrentTarget.normalized * moveMagnitude;
            return 0;
        }
        else
        {
            transform.position = currentTarget;
            isMovingToStart = !isMovingToStart;
            return moveMagnitude - toCurrentTarget.magnitude;
        }
    }

    private void OnDrawGizmos()
    {
        if (!isRunning)
        {
            startPosition = start.transform.position;
            endPosition = end.transform.position;
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(startPosition, endPosition);
        }
    }
}
