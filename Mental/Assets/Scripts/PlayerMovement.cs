using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] WalkingSound walking;
    [SerializeField] bool isWalking = false;
    [SerializeField] float walkingTimer;
    

    [Header("Movement")]
    public float moveSpeed;
    private float baseMoveSpeed;
    public float groundDrag;


    [Header("Ground Check")]
    public float PlayerHeight;
    public LayerMask WhatIsGround;
    bool grounded;

    public Transform orientation;

    float horizontalInput;
    float verticaleInput;

    Vector3 moveDirection;
    Rigidbody rb;


     private void Start()
    {
        baseMoveSpeed = moveSpeed;
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        walking = GetComponent<WalkingSound>();
    }


    private void Update()
    {
        //ground check
        grounded = Physics.Raycast(transform.position, Vector3.down, PlayerHeight * 0.5f + 0.2f, WhatIsGround);
        MyInput();

        //håndtere drag
        if (grounded)

            rb.drag = groundDrag;
        else
            rb.drag = 0;


        if (Input.GetKeyDown("left shift"))
        {
            moveSpeed = moveSpeed * 2;
        }
        else if (Input.GetKeyUp("left shift"))
        {
            moveSpeed = baseMoveSpeed;
        }


    }
    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticaleInput = Input.GetAxisRaw("Vertical");
        
        if(moveDirection.x <0 || moveDirection.x > 0|| moveDirection.y < 0 || moveDirection.y > 0|| moveDirection.z < 0 || moveDirection.z > 0)
        
            if (!isWalking)
                WalkingSound();
        

    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * horizontalInput  - orientation.right * verticaleInput;
        rb.AddForce(moveDirection.normalized * -moveSpeed * 10f,ForceMode.Force);


    }
    
    void WalkingSound()
    {

        StartCoroutine("PlayWalkingSound", walkingTimer);
    }

    IEnumerator PlayWalkingSound(float timer)
    {
        var randomIndex = Random.Range(0, 2);
        walking.audioSource.clip = walking.walkingSounds[randomIndex];

        walking.audioSource.Play();
        isWalking = true;

        yield return new WaitForSeconds(timer);
        isWalking = false;
    }
    
    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }
}
