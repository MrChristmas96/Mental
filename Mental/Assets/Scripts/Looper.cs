using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Looper : MonoBehaviour
{
    [SerializeField] private GM gameMaster;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Debug.Log("Loaded scene" + gameMaster.loopCount);
            gameMaster.loadScene("Hallway");
        }
    }
}
