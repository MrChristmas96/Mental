using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]

    public float moveSpeed;

    public Transform orientation;

    float horizontalInput;
    float verticaleInput;

    Vector3 moveDirection;
    Rigidbody rb;


     private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }


    private void Update()
    {
        MyInput();
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticaleInput = Input.GetAxisRaw("Vertical");


    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * horizontalInput  - orientation.right * verticaleInput;
        rb.AddForce(moveDirection.normalized * moveSpeed * 10f,ForceMode.Force);
    }
}
