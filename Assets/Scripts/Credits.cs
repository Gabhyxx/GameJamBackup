using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    void Start()
    {
         StartCoroutine(WaitForSceneLoad());
    }

    private IEnumerator WaitForSceneLoad() {
    yield return new WaitForSeconds(15);
    SceneManager.LoadScene(3);
    yield return new WaitForSeconds(10);
     Application.Quit();
    
}

   
}
