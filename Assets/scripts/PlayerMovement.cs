using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float jump = 25f;
    float moveVelocity;
    public Rigidbody2D rb2d;
    bool isGrounded = true;
    float threshold = -50f;

    void Update()
    {
        if (transform.position.y < threshold)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        

        //jumping & grounded?
        if (isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
                isGrounded = false;
            }
        }
            

        

        moveVelocity = 0;

        //Left Right Movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
       if (other.CompareTag("Platform"))
       {
            isGrounded = true;
           
       }

        if (isGrounded == true)
        { 
            Debug.Log("grounded is true");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (isGrounded == false)
        {
            Debug.Log("Grounded is false");
        }
    }
}