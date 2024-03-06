using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnGO : MonoBehaviour
{
    [SerializeField] private GameObject document;

    [SerializeField] private int frameInterval;
    [SerializeField] private float secondsToWait;

    private Vector3 spawnPosition;

    private int documentCount;

    private void Awake()
    {
        spawnPosition = gameObject.transform.position;
    }

    private void Start()
    {
        InvokeRepeating("SpawnDocuments", secondsToWait, secondsToWait);
        documentCount = GameObject.FindGameObjectsWithTag("Documents").Length;
    }

    private void Update()
    {

        CountingDocuments();
        //SpawnDocuments();
    }

    private void CountingDocuments()
    {
        documentCount = GameObject.FindGameObjectsWithTag("Documents").Length;

        for (int i = 0; i <= documentCount; i++)
        {
            Debug.Log("Número de documentos: " + documentCount);
        }
    }

    private void SpawnDocuments()
    {
        if (documentCount == 0)
        {
            //Invoke("InstantiateDocument", secondsToWait);
            InstantiateDocument();
        }
    }

    void InstantiateDocument()
    {
        Instantiate(document, spawnPosition, quaternion.identity);
    }
}
