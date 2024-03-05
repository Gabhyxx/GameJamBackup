using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    Vector3 mousePositionOffset;

    private Vector3 GetMouseWorldPossition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPossition();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPossition() + mousePositionOffset;
    }
}
