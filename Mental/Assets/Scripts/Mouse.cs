using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mouse : MonoBehaviour
{
    public float mouseSenX;
    public float mouseSenY;

    public Transform Orientation;

    float xRotation;
    float yRotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSenX * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSenY * Time.deltaTime;

        yRotation += mouseX;
        xRotation -= mouseY;

        
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        Orientation.rotation = Quaternion.Euler(0, yRotation, 0);

        
        
    }
}
