using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    Vector3 mousePositionOffset;
    Rigidbody2D rb2d;

    bool limitContact;


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DropZone")
        {
            rb2d.gravityScale = 1;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DropZone")
        {
            rb2d.gravityScale = 0;
            Destroy(gameObject);
        }
    }
}
