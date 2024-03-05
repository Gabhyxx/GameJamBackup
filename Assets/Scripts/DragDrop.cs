using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    Vector3 mousePositionOffset;

    bool limitContact;
    

    private Vector3 GetMouseWorldPossition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPossition();
        
    }

    private void OnMouseUp()
    {
        limitContact = false;
    }

    private void OnMouseDrag()
    {
        if (limitContact == false)
        {
            transform.position = GetMouseWorldPossition() + mousePositionOffset;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Limit")
        {
            limitContact = true;
            //moveObject = collision.gameObject.GetComponent<InteractuableLimit>().relocate;
            //transform.position = transform.position + moveObject;
        }
    }
}
