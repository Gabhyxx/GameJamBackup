using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StampScript : MonoBehaviour
{
    private Animator anim;
    private bool isUnfolded;
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
        isUnfolded = true;
    }

    public void CloseStamp()
    {
        if (isUnfolded == true) 
        {
            anim.SetBool("CloseStampAnimation", true);
            anim.SetBool("StampAnimation", false);
            isUnfolded = false;
        }
    }
}
