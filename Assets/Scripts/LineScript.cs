using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour
{
    public LineRenderer line;
    private Vector2 lastPosition;
    private bool isDrawing = false; 

    [SerializeField]
    private float minDistance = 0.1f;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = 0;
    }

    public void StartLine(Vector2 position)
    {
        line.positionCount = 1;
        line.SetPosition(0, position);
        lastPosition = position;
        isDrawing = true; 
    }

    public void EndLine()
    {
        isDrawing = false; 
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 startPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            StartLine(startPosition); 
        }
        else if (Input.GetMouseButtonUp(0))
        {
            EndLine(); 
        }

        if (isDrawing)
        {
            UpdateLine();
        }
    }

    public void UpdateLine()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (line.positionCount == 0 || Vector2.Distance(currentPosition, lastPosition) > minDistance)
            {
                line.positionCount++;
                line.SetPosition(line.positionCount - 1, currentPosition);
                lastPosition = currentPosition;
            }
        }
    }
}
