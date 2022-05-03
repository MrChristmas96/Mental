using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator DoorAnim;

    public AudioSource OpenDoor;
    public AudioSource CloseDoor;

    private bool DoorOpen = false;

    private void Awake()
    {
        DoorAnim = gameObject.GetComponent<Animator>();
        
    }

    public void PlayAnimation()
    {
        if (!DoorOpen)
        {
            DoorAnim.Play("DoorOpen", 0, 0.0f);
            DoorOpen = true;
            OpenDoor.Play();
            
        
            
        }
        else
        {
            DoorAnim.Play("DoorClose", 0, 0.0f);
            DoorOpen = false;
            CloseDoor.Play();
        }
    }
}
