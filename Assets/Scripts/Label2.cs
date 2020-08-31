using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Label2 : MonoBehaviour
{
    public static int num;
    Text label;
    // Start is called before the first frame update
    void Start()
    {
        label = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        label.text = "Room " + num;
    }
}
