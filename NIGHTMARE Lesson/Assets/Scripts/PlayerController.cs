using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 9000.0f;
    public float rotateSpeed = 4000.0f;
    public float jumpHeight = 150.0f;
    bool isGrounded = true;
    bool isAlive = true;
    int health = 10;

    public GameObject player;

    Animator animController;
    Rigidbody rb;

    void Start()
    {
        animController = player.GetComponent<Animator>();
        rb      = GetComponent<Rigidbody>();
       // gameOverManager.isGameOver = false;
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

        if(health < 10)
        {
           Die();

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            isGrounded = true;
        }
        if(collision.gameObject.tag == "Void")
        {
            // isAlive = false;
            // animController.SetBool("Dead", true);
            Die();
        }
        if(collision.gameObject.tag == "Trap")
        {
            health -= 2;
            //add script for slider here 
        }
    }

    public void Die()
    {
        isAlive = false;
        animController.SetBool("Dead", true);
        
        StartCoroutine(GameOverTransition());
    }

    private IEnumerator GameOverTransition()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("GameOver");
    }
}
