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
        Debug.Log("Estampado: " + isStamped);
    }
    public void PrintGreenStamp()
    {
        isStamped = true;
        isGreen = true;
        isRed = false;
        Debug.Log("Verde: " + isGreen);
        Debug.Log("Rojo: " + isRed);
        
    }

    public void PrintRedStamp()
    {
        isStamped = true;
        isGreen = false;
        isRed = true;
        Debug.Log("Verde: " + isGreen);
        Debug.Log("Rojo: " + isRed);
        Debug.Log("Estampado: " + isStamped);
    }
}
