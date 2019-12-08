using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
   private Rigidbody playerRb;
   private Animator playerAnim;
   public float jumpForce = 10;
   public float gravityModifier;
   public bool isOnGround = true;
   public bool gameOver;
   public float speed = 15;
   public float turnSpeed =60;
   private Gamemanager GameManagerMaster;
    // Start is called before the first frame update
    void Start()
    {
        
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig"); 
        }
        isOnGround =true;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.CompareTag("Ground"))
        {
               isOnGround = true;
        } else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;
            GameManagerMaster.CallEventGameOver();
        }
    }
}