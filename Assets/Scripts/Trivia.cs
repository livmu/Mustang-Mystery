using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trivia : MonoBehaviour
{
    //public int index;
    public string sceneToLoad;
    public void Correct()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
