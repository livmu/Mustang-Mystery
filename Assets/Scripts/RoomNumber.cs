using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomNumber : MonoBehaviour
{
    public static int roomNumber = 1;
    Text room;
    // Start is called before the first frame update
    void Start()
    {
        room = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        room.text = "" + roomNumber;
    }
}
