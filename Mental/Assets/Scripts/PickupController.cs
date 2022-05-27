using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    [SerializeField] private GM gameMaster;
    [SerializeField] private GameObject pickupUI;
    [SerializeField] private GameObject pickup;
    public bool showingPickUp = false;

    [SerializeField] private TextController textController;

    private void Start()
    {
        gameMaster = FindObjectOfType<GM>();
        pickup = GameObject.FindGameObjectWithTag("Pickup");
        pickupUI = GameObject.FindGameObjectWithTag("PickupUI");
        pickupUI.SetActive(false);
    }
    private void Update()
    {
        pickup = GameObject.FindGameObjectWithTag("Pickup");
        if (Input.GetKeyDown("e"))
        {
            if (showingPickUp && pickupUI != null)
            {
                pickupUI.SetActive(false);
            }
            
        }
    }
    public void PickedUp()
    {

        if (gameMaster.loopCount == 0)
        {

            pickup.SetActive(false);
            pickupUI.SetActive(true);
            textController.StartCoroutine(textController.KeyCard());
            StartCoroutine(Wait());
        }
        else if (gameMaster.loopCount == 1)
        {

            pickup.SetActive(false);
            pickupUI.SetActive(true);
            textController.StartCoroutine(textController.Paper());
            StartCoroutine(Wait());
        }
        else if(gameMaster.loopCount == 2)
        {
            pickup.SetActive(false);
            pickupUI.SetActive(true);
            textController.StartCoroutine(textController.Knife());
            StartCoroutine(Wait());
        }
        else if (gameMaster.loopCount == 3)
        {
            pickup.SetActive(false);
            pickupUI.SetActive(true);
            textController.StartCoroutine(textController.Death());
            StartCoroutine(Wait());
        }
        else if (gameMaster.loopCount == 4)
        {
            pickup.SetActive(false);
            pickupUI.SetActive(true);
            textController.StartCoroutine(textController.Picture());
            StartCoroutine(Wait());
        }
        else if (gameMaster.loopCount == 5)
        {
            pickup.SetActive(false);
            pickupUI.SetActive(true);
            textController.StartCoroutine(textController.Collection());
            StartCoroutine(Wait());
        }

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        showingPickUp = true;
    }

    public void updatePickup()
    {
        pickup = GameObject.FindGameObjectWithTag("Pickup");
    }
}
