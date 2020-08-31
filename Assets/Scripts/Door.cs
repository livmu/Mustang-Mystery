using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Door : MonoBehaviour
{
    private static int roomNumber = 1;
    private static int previousRoom = 0;
    private static int door = 0;
  //  private static int[] indexArr = { 0, 1, 2 };
    private static int[] neighbors = new int[6];
    private static int[] doors = new int[3];
  //  private static int[][] array = new int[30][];
    private static string doorName;

    void Start()
    {
        SetDoors();
    }

    void Update()
    {
        Label1.num = doors[0];
        Label2.num = doors[1];
        Label3.num = doors[2];
    }

    public void SetDoors()
    {
        SetNeighbors();

        for (int k = 0; k < neighbors.Length; k++)
        {
            if (neighbors[k] == previousRoom)
            {
                neighbors[k] = 0;
            }
        }

        for (int i = 0; i < doors.Length;)
        {
            int index = Random.Range(0, 6);

            if (previousRoom > 0 && door == i)
            {
                doors[i] = previousRoom; 
                i++;
            }
            
            else if (neighbors[index] > 0)
            {
                doors[i] = neighbors[index];
                neighbors[index] = 0;
                i++;
            }
        }

        SetNeighbors();
    }

    public void SetNeighbors()
    {
        roomNumber = RoomNumber.roomNumber;

        neighbors[0] = roomNumber - 1;
        neighbors[1] = roomNumber - 6;
        neighbors[2] = roomNumber + 1;
        neighbors[3] = roomNumber + 7;
        neighbors[4] = roomNumber + 6;
        neighbors[5] = roomNumber + 5;

        if (roomNumber == 1)
        {
            neighbors[0] = roomNumber + 29;
            neighbors[1] = roomNumber + 24;
            neighbors[3] = roomNumber + 25;
        }

        if (roomNumber == 2 || roomNumber == 4)
        {
            neighbors[1] = roomNumber + 24;
        }

        if (roomNumber == 3 || roomNumber == 5)
        {
            neighbors[1] = roomNumber + 24;
            neighbors[3] = roomNumber + 25;
            neighbors[5] = roomNumber + 23;
        }

        if (roomNumber == 6)
        {
            neighbors[1] = roomNumber + 24;
            neighbors[3] = roomNumber - 5;
        }

        if (roomNumber == 24)
        {
            neighbors[3] = roomNumber - 5;
        }

        if (roomNumber == 25)
        {
            neighbors[1] = roomNumber - 6;
            neighbors[3] = roomNumber - 5;
            neighbors[4] = roomNumber - 24;
        }

        if (roomNumber == 26 || roomNumber == 28)
        {
            neighbors[1] = roomNumber - 6;
            neighbors[3] = roomNumber - 23;
            neighbors[4] = roomNumber - 24;
            neighbors[5] = roomNumber - 25;
        }

        if (roomNumber == 27 || roomNumber == 29)
        {
            neighbors[1] = roomNumber - 6;
            neighbors[3] = roomNumber - 5;
            neighbors[4] = roomNumber - 24;
            neighbors[5] = roomNumber - 7;
        }

        if (roomNumber == 30)
        {
            neighbors[1] = roomNumber - 6;
            neighbors[2] = roomNumber - 5;
            neighbors[3] = roomNumber - 29;
            neighbors[4] = roomNumber - 24;
            neighbors[5] = roomNumber - 25;
        }
    }

    void OnTriggerEnter2D(Collider2D col) //public void OnTriggerEnter2D
    {
        doorName = GetComponent<Door>().gameObject.name;

        if (doorName == "Door1")
        {
            door = 0;
        }
        else if (doorName == "Door2")
        {
            door = 1;
        }
        else if (doorName == "Door3")
        {
            door = 2;
        }

        if (col.gameObject.tag.Equals("Player"))
        {
            previousRoom = roomNumber;
            RoomNumber.roomNumber = doors[door];
            SetDoors();
        }
    }
}
