using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{

    [SerializeField] private Animator Door = null;
    [SerializeField] private bool openTriger2 = false;
    [SerializeField] AudioSource OpenDoor;
    [SerializeField] AudioSource Laughs;



    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("3");
        if (openTriger2)
        {
            Debug.Log("4");
            Door.Play("DoorOpen", 0, 0.0f);
            OpenDoor.Play();
            gameObject.SetActive(false);
            Laugh();

            
        }


    }

    private Coroutine()
    {

        yield return WaitForSeconds(2);
    }

    private IEnumerator Laugh()
    {
        
        Laughs.Play();

        yield return WaitForSeconds(2);
    }

}

