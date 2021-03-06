using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    [SerializeField] private Animator Door = null;
    [SerializeField] private bool openTriger = false;
    [SerializeField] AudioSource OpenDoor;
    [SerializeField] AudioSource Laugh;
    [SerializeField] AudioSource Breath;
    [SerializeField] AudioSource Laugh2;
    [SerializeField] AudioSource Boh;
    [SerializeField] AudioSource uhyggeligt1;
    [SerializeField] AudioSource uhyggeligt2;
    [SerializeField] GameObject lys;
    [SerializeField] GameObject lys1;
    [SerializeField] RoomGenerator roomGenerator;


    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.name == "trigggerDoor")
        {
            roomGenerator.CreateRoom();
            Door.Play("DoorOpen", 0, 0.0f);
            OpenDoor.Play();
            gameObject.SetActive(false);  
        }

        if(gameObject.name == "TriggerLaugh")
        {
            Laugh.Play();
            gameObject.SetActive(false);
        }

        if(gameObject.name == "TriggerBreath")
        {
            Breath.Play();
            gameObject.SetActive(false);
        }

        if(gameObject.name == "TriggerLaugh2")
        {
            Laugh2.Play();
            gameObject.SetActive(false);
        }

        if(gameObject.name == "Triggerbooh")
        {
            Boh.Play();

            lys.SetActive(true);
            lys1.SetActive(true);

            gameObject.SetActive(false);
            
           
        }
        if (gameObject.name == "TriggerDoorKnock")
        {
            
            uhyggeligt1.Play();

            gameObject.SetActive(false);


        }
        if (gameObject.name == "trigger2")
        {

            uhyggeligt2.Play();
            gameObject.SetActive(false);


        }



    }

}
