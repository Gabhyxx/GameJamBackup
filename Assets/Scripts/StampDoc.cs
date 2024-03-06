using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class StampDoc : MonoBehaviour
{
    bool isGreen, isRed;
    public bool isStamped;

    private void Start()
    {
        isGreen = false;
        isRed = false;
        isStamped = false;
        
    }
    public void PrintGreenStamp()
    {
        isStamped = true;
        isGreen = true;
        isRed = false;
       
        
    }

    public void PrintRedStamp()
    {
        isStamped = true;
        isGreen = false;
        isRed = true;
       
    }
}
