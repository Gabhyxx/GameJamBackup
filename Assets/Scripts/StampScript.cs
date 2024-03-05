using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StampScript : MonoBehaviour
{
    private Animator anim;
    //private Vector2 stampMovePosition;
    //

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    //private void Start()
    //{
    //    stampMovePosition = gameObject.transform.position - gameObject.transform.position / 2;
    //}

    //public void Move()
    //{
    //    transform.position = new Vector2(stampMovePosition.x, gameObject.transform.position.y);
    //}

    public void ExecuteAnimation()
    {
        anim.SetBool("StampAnimation", true);
    }

    public void OnClick()
}
