using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AskTrivia : MonoBehaviour
{
    public string sceneToLoad;
    //public int index;

    void OnTriggerEnter2D(Collider2D other) //public void OnTriggerEnter2D
    {
        if (other.CompareTag("Player"))// && !other.isTrigger)
        {
            SceneManager.LoadScene(sceneToLoad);
            //SceneManager.LoadScene(index);
            // GetCompoent(TextMesh).text = "Hellow Word!";
        }
    }
}
