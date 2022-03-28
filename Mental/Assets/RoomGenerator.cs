using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator : MonoBehaviour
{

    public GameObject[] room;
    public GameObject[] rooms;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            for(int i = 0; i < room.Length; i++)
            {
                int r = Random.Range(0, rooms.Length);
                Instantiate(rooms[r], room[i].transform.position, Quaternion.identity);
            }

        }
        if (Input.GetKeyDown("z"))
        {
            GameObject[] destroy = GameObject.FindGameObjectsWithTag("Room");
            foreach(GameObject room in destroy)
            {
                Destroy(room);
            }
           
        }
    }
}
