using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnapController : MonoBehaviour
{
    public List<Transform> snapPoints;
    public List<DragAndDrop> draggableObjects;
    public float snapRange = 0.5f;
    private Dictionary<Transform, DragAndDrop> occupiedSnapPoints = new Dictionary<Transform, DragAndDrop>();
    private int requiredSnapCount = 4;
    public Button completionButton;

    void Start()
    {
        completionButton.gameObject.SetActive(false);

        foreach (DragAndDrop draggable in draggableObjects)
        {
            draggable.dragEndedCallBack = OnDragEnded;
            Debug.Log($"Assigned dragEndedCallBack to {draggable.name}");
        }
    }

    private void OnDragEnded(DragAndDrop draggable)
    {
        float closestDistance = -1;
        Transform closestSnapPoint = null;

        foreach (Transform snapPoint in snapPoints)
        {
            float currentDistance = Vector3.Distance(draggable.transform.localPosition, snapPoint.localPosition);
            if (closestSnapPoint == null || currentDistance < closestDistance)
            {
                closestSnapPoint = snapPoint;
                closestDistance = currentDistance;
            }
        }

        if (closestSnapPoint != null && closestDistance <= snapRange)
        {
            // find previous snap point manually instead of using firstordefault
            Transform previousSnapPoint = null;
            foreach (var entry in occupiedSnapPoints)
            {
                if (entry.Value == draggable)
                {
                    previousSnapPoint = entry.Key;
                    break; //exit once found
                }
            }

            if (previousSnapPoint != null)
            {
                occupiedSnapPoints.Remove(previousSnapPoint);
            }

            occupiedSnapPoints[closestSnapPoint] = draggable;
            draggable.transform.localPosition = closestSnapPoint.localPosition;

            //CheckAllSnapPointsFilled();
            CheckSnapPointsCount();
        }
    }

    private void CheckSnapPointsCount()
    {
        Debug.Log($"Checking snap count: {occupiedSnapPoints.Count}/{requiredSnapCount}"); 

        if (occupiedSnapPoints.Count >= requiredSnapCount)
        {
            Debug.Log($"The {requiredSnapCount} snap points are occupied!");
            completionButton.gameObject.SetActive(true); 
        }
        else
        {
            completionButton.gameObject.SetActive(false); 
        }
    
    }
}
