using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{


    

    [SerializeField] AudioSource Laughs;



    private void OnTriggerEnter(Collider other)
    {
        
        
            Debug.Log("3");
            
            Laughs.Play();
            gameObject.SetActive(false);
           


    }
    /*
    private Coroutine()
    {

        yield return WaitForSeconds(2);
    }

    private IEnumerator Laugh()
    {
        
        Laughs.Play();

        yield return WaitForSeconds(2);
    }
    */
}

