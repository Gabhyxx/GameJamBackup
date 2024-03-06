using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    Vector3 mousePositionOffset;
    Rigidbody2D rb2d;
    StampDoc stampDoc;

    bool limitContact;
    bool stamped;
    private AudioSource audioSource;
    [SerializeField] AudioClip music;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        stampDoc = gameObject.GetComponent<StampDoc>();
    }

    private void Start()
    {
        stamped = stampDoc.isStamped;
        audioSource = GetComponent<AudioSource>();
        
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
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Destroy(gameObject);
        audioSource.clip = music;
        audioSource.Play();
    
        
    }
}
