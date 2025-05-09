using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public delegate void DragEndedDelegate(DragAndDrop draggableObject);

    public DragEndedDelegate dragEndedCallBack;

    private bool isDragged = false;
    private Vector3 mouseDragStartPosition;
    private Vector3 spriteDragStartPosition;
        
    private void OnMouseDown()
    {
        Debug.Log($"Mouse clicked on {gameObject.name}");
        isDragged = true;
        mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteDragStartPosition = transform.localPosition;
    }

    private void OnMouseDrag()
    {
        if(isDragged)
        {
            //transform.localPosition = mouseDragStartPosition + Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPosition;
            Vector3 newPosition = mouseDragStartPosition + Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPosition;
            newPosition.z = spriteDragStartPosition.z; // Keep original Z-position
            transform.localPosition = newPosition;
        }
    }

    private void OnMouseUp()
    {
        isDragged = false;
        dragEndedCallBack(this);
    }

    //private void OnMouseUp()
    //{
    //    Debug.Log($"Mouse released on {gameObject.name}"); // Debug check
    //    isDragged = false;

    //    if (dragEndedCallBack != null)
    //    {
    //        Debug.Log($"Calling dragEndedCallBack for {gameObject.name}");
    //        dragEndedCallBack(this);
    //    }
    //    else
    //    {
    //        Debug.LogError($"dragEndedCallBack is NULL for {gameObject.name}");
    //    }
    //}
}
