using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Olivia : MonoBehaviour
{
    public static SpriteRenderer player;
    public static BoxCollider2D box;
    public static int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        int[] array = PlayerLocation.array;
        int index = Random.Range(1, 30);
        while (num == 0)
        {
            num = array[index];
            PlayerLocation.array[index] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        player = GetComponent<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
        if (RoomNumber.roomNumber == num)
        {
            player.enabled = true;
            box.enabled = true;
        } 
        
        else
        {
            player.enabled = false;
            box.enabled = false;
        }
    }
}
