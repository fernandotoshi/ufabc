using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Vector3 direction;
    private Animator anim;
    private Rigidbody rb;
    public int gold = 10;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetAxis() return a value between -1 and 1. The reference Key is on Project Settings > Input Manager
        float axisX = Input.GetAxis("Horizontal");
        float axisZ = Input.GetAxis("Vertical");

        direction = new Vector3(axisX, 0, axisZ);

        // transform acess the component Transform on the Inspector
        // multiplies by Time.deltaTime because the method Update() is called once per frame and we need to normalize by second
        // transform.Translate(direction * speed * Time.deltaTime);
        
        // Player moving
        if (direction != Vector3.zero)
        {
            // Animator section
            anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }
    }

    // Update with a fixed period
    private void FixedUpdate()
    {
        // Section RigidBody
        rb.MovePosition(rb.position + (direction * speed * Time.deltaTime));

        // Rotation of player
        if(direction != Vector3.zero)
        {
            Quaternion rotation = Quaternion.LookRotation(direction);
            rb.MoveRotation(rotation);
        }
    }

}
