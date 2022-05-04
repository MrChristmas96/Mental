using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    [SerializeField] private GM gameMaster;
    [SerializeField] private GameObject keycardUI;
    [SerializeField] private GameObject keycard;

    private void Start()
    {
        gameMaster = FindObjectOfType<GM>();
        keycardUI.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            
            keycardUI.SetActive(false);
        }
    }
    public void PickUpKeyCard()
    {
        keycard.SetActive(false);
        keycardUI.SetActive(true);
    }
}
