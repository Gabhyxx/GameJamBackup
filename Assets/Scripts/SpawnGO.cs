using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnGO : MonoBehaviour
{
    [SerializeField] private GameObject document;
    [SerializeField] private GameObject[] character, charPicture;

    [SerializeField] private int frameInterval;
    [SerializeField] private float secondsToWait;
    

    private Vector3 spawnPosition;

    private int documentCount;
    int cont;

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
    }

    private void CountingDocuments()
    {
        documentCount = GameObject.FindGameObjectsWithTag("Documents").Length;

        for (int i = 0; i <= documentCount; i++)
        {
            //Debug.Log("N�mero de documentos: " + documentCount);
        }
    }

    private void SpawnDocuments()
    {
        if (documentCount == 0)
        {
            Instantiate(document, spawnPosition, quaternion.identity);
            cont++;
            if(cont == 5){
               StartCoroutine(WaitForSceneLoad());
            }
        }
    }

     private IEnumerator WaitForSceneLoad() {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2); 
    }

    private void PickCharacter()
    {
        int index = UnityEngine.Random.Range(0, character.Length);
    }
}
