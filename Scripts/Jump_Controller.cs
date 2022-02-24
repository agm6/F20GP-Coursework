using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_Controller : MonoBehaviour
{
    public Rigidbody rb;
    public float buttonTime = 0.5f;
    public float jumpHeight = 5;
    public float cancelRate = 100;
    float jumpTime;
    bool jumping;
    bool jumpCancelled;
    public float gravityScale = 3;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpForce = Mathf.Sqrt(jumpHeight * -2 * (Physics.gravity.y * gravityScale));
            rb.AddForce(new Vector2(0, jumpForce), ForceMode.Impulse);
            jumping = true;
            jumpCancelled = false;
            jumpTime = 0;
        }
        if (jumping)
        {
            jumpTime += Time.deltaTime;
            if (Input.GetKeyUp(KeyCode.Space))
            {
                jumpCancelled = true;
            }
            if (jumpTime > buttonTime)
            {
                jumping = false;
            }
        }
    }
    private void FixedUpdate()
    {
        if (jumpCancelled && jumping && rb.velocity.y > 0)
        {
            rb.AddForce(Vector2.down * cancelRate);
        }

        rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);
    }
}
