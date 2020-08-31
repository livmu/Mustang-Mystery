using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oumsri : MonoBehaviour
{
    public static SpriteRenderer player;
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
        if (RoomNumber.roomNumber == num)
        {
            player.enabled = true;
            GetComponent<BoxCollider2D>().enabled = true;
        }

        else
        {
            player.enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
