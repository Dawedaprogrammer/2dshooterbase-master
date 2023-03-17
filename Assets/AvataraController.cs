using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AvataraController : MonoBehaviour
{
    
    [SerializeField]
    float jumpForce = 1000;

    [SerializeField]
    Transform GroundChekcer;

    [SerializeField]
    LayerMask groundLayer;

    Rigidbody2D rb;

    bool hasRealsesedJump = true;
    bool isGrounded = false;
    
    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       isGrounded = Physics2D.OverlapCircle(GroundChekcer.position, 0.3f, groundLayer);
       
        if(Input.GetAxisRaw("Jump") > 0 && hasRealsesedJump && isGrounded == true)
        {
            
            print("jump");
            rb.AddForce(Vector2.up * jumpForce);
            hasRealsesedJump = false;
        }
        else if (Input.GetAxisRaw("Jump") == 0)
        {
            hasRealsesedJump = true;
        }

        float xMove = Input.GetAxisRaw("Horizontal");
        
        Vector2 movement = new Vector2(xMove, 0) * speed * Time.deltaTime;

        transform.Translate(movement);

    

    }



}
