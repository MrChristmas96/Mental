using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private Animator Door = null;
    [SerializeField] private bool openTriger = false;
    [SerializeField] AudioSource OpenDoor;
   


    private void OnTriggerEnter(Collider other)
    {

            Debug.Log("1");
            if (openTriger)
            {
                Debug.Log("2");
                Door.Play("DoorOpen",0 , 0.0f);
                OpenDoor.Play();
                gameObject.SetActive(false);
            }
        
        
    }
    
}
