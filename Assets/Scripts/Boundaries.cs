using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    void Start() { 
    
    }

    void Update() {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4f, 4f), Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z); 
    }
}
