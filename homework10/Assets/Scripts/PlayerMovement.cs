using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;

    public float gravity = -9.81f;
    Vector3 velocity;

    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    public int score;
    public AudioSource coinSound;
    public TextMeshProUGUI scoreDisplay;

    private void Start()
    {
        coinSound = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
            gravity = -9.81f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //moving the character
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        //gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        //jump
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (!controller.isGrounded && hit.normal.y < 0.1f)
        {
            if (Input.GetButtonDown("Jump"))
            {
                //Debug.DrawRay(hit.point, hit.normal, Color.red, 1.25f);
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                
            }
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Coin")
        {
            //Add to score
            score += 100;
            scoreDisplay.text = "Score: " + score.ToString();
            coinSound.Play();
            Destroy(other.gameObject);
        }
    }

}
