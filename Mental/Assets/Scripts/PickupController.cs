using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    [SerializeField] private GM gameMaster;
    [SerializeField] private GameObject pickupUI;
    [SerializeField] private GameObject pickup;
    private bool showingPickUp;

    private void Start()
    {
        gameMaster = FindObjectOfType<GM>();
        pickup = GameObject.FindGameObjectWithTag("Pickup");
        pickupUI = GameObject.FindGameObjectWithTag("PickupUI");
        pickupUI.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if (showingPickUp)
            {
                pickupUI.SetActive(false);
            }
            
        }
    }
    public void PickedUp()
    {
        StartCoroutine(Wait());
        pickup.SetActive(false);
        pickupUI.SetActive(true);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        showingPickUp = true;
    }
}
