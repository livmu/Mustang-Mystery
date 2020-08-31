using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowsDisplayNumber : MonoBehaviour

{

    public static int arrowsAmount = 3;
    Text arrows;
    // Start is called before the first frame update
    void Start()
    {
        arrows = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        arrows.text = "ARROWS: " + arrowsAmount;
    }

}