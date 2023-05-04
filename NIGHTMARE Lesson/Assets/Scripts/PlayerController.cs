using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 70000.0f;
    public float rotateSpeed = 20000.0f;

    public GameObject player;

    Animator animController;
    Rigidbody rb;

    void Start()
    {
        animController = player.GetComponent<Animator>();
        rb      = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // if (Input.GetAxis("Vertical"))
        // {
        //     transform.Translate(0, 0, walkSpeed * Time.deltaTime);
        //     animController.SetBool("Walk", true);
        // }

        // if (Input.GetAxis("Horizontal"))
        // {
        //     transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        //     animController.SetBool("Walk", true);
        // }
        // else
        // {
        //     animController.SetBool("Walk", false);
        // }
        Vector3 input = new Vector3(0, Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (input.magnitude > 0.001)
        {
            rb.AddRelativeTorque(new Vector3(0, input.y * rotateSpeed * Time.deltaTime, 0));
            
            rb.AddRelativeForce(new Vector3(0, 0, input.z * walkSpeed * Time.deltaTime));

            animController.SetBool("Walk", true);
        }
        else
        {
            animController.SetBool("Walk", false);
        }

    }
}
