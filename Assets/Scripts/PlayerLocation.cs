using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocation : MonoBehaviour
{
    public static int[] array;

    // Start is called before the first frame update
    void Start()
    {
        array = new int[30];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
