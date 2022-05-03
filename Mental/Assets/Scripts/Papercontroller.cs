using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Papercontroller : MonoBehaviour
{
    public bool isOpen;

    public void OpenPaper()
    {
        if(!isOpen)
        {
            isOpen = true;
            Debug.Log("Paper is now open");
        }
    }
    // Start is called before the first fra me update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
