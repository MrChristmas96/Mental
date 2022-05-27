using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator : MonoBehaviour
{

    public GameObject[] roomABC;
    public GameObject[] rooms;
    [SerializeField] private GM gameMaster;

    public int loopNumber;

    private void Start()
    {
        gameMaster = FindObjectOfType<GM>();
        loopNumber = gameMaster.loopCount;
    }
    void Update()
    {

        if (Input.GetKeyDown("z"))
        {
            GameObject[] destroy = GameObject.FindGameObjectsWithTag("Room");
            foreach(GameObject room in destroy)
            {
                Destroy(room);
            }
           
        }
    }

    public void CreateRoom()
    {
        Debug.Log("Generated New Rooms");
        GameObject[] destroy = GameObject.FindGameObjectsWithTag("Room");
        foreach (GameObject room in destroy)
        {
            Destroy(room);
        }


        if(loopNumber == 1)
        {
            int r = Random.Range(0, rooms.Length - 1);
            Instantiate(rooms[r], roomABC[0].transform.position, Quaternion.identity);
            int t = Random.Range(0, rooms.Length - 1);
            Instantiate(rooms[t], roomABC[2].transform.position, Quaternion.identity);

            Instantiate(rooms[2], roomABC[1].transform.position, Quaternion.identity);
        }
        else if(loopNumber == 2)
        {
            int r = Random.Range(0, rooms.Length - 1);
            Instantiate(rooms[r], roomABC[0].transform.position, Quaternion.identity);
            int t = Random.Range(0, rooms.Length - 1);
            Instantiate(rooms[t], roomABC[2].transform.position, Quaternion.identity);

            Instantiate(rooms[2], roomABC[1].transform.position, Quaternion.identity);
        }
        else
        {
            for (int i = 0; i < roomABC.Length; i++)
            {
                int r = Random.Range(0, rooms.Length);
                Instantiate(rooms[r], roomABC[i].transform.position, Quaternion.identity);
            }
        }
    }
}
