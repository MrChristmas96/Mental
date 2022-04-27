using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorRaycast : MonoBehaviour
{
    [SerializeField] private int rayLength = 5;
    [SerializeField] private LayerMask LayerMask;
    [SerializeField] private string exLayerName = null;

    private DoorController raycastObj;
    [SerializeField] private KeyCode OpenDoorKey = KeyCode.E;
    [SerializeField] private Image crosshair = null;
    private bool isCrossHairActive;
    private bool doOnce;

    private const string InterActableTag = "InteractiveObject";

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        int mask = 1 << LayerMask.NameToLayer(exLayerName) | LayerMask.value;
        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            if (hit.collider.CompareTag(InterActableTag))
            {
                if (!doOnce)
                {
                    raycastObj = hit.collider.gameObject.GetComponent<DoorController>();
                   /* CrosshairChange(true);*/
                }
               /* isCrossHairActive = true;*/
                doOnce = true;
                if (Input.GetKeyDown(OpenDoorKey))
                {
                    raycastObj.PlayAnimation();
                }
            }

        }
        else
        {
            doOnce = false;
        }
        /*
        else 
        {
            if (isCrossHairActive)
            {
                CrosshairChange(false);
                doOnce = false;
            }
        }*/
    }

    /*
    void CrosshairChange(bool on)
    {
        if(on && !doOnce)
        {
            crosshair.color = Color.white;
        }
        else
        {
            crosshair.color = Color.black;
            isCrossHairActive = false;
        }
    }*/
}
