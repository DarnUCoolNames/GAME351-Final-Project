using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 70000.0f;
    public float rotateSpeed = 10000.0f;
    public float jumpHeight;
    bool isGrounded = true;
    bool isAlive = true;
    //int health = 10;

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
        Vector3 input = new Vector3(0, Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (input.magnitude > 0.001 && isAlive)
        {
            rb.AddRelativeTorque(new Vector3(0, input.y * rotateSpeed * Time.deltaTime, 0));
            
            rb.AddRelativeForce(new Vector3(0, 0, input.z * walkSpeed * Time.deltaTime));

            animController.SetBool("Walk", true);
            animController.SetBool("isGrounded", true);
        }
        else
        {
            animController.SetBool("Walk", false);
            animController.SetBool("isGrounded", true);
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded && isAlive)
        {
            rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
            isGrounded = false;
            animController.SetBool("Jumped", true);
            animController.SetBool("isGrounded", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            isGrounded = true;
        }
    }
}
