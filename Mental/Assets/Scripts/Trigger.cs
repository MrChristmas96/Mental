using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] GameObject light1;

    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("trigger!");
    }
}
