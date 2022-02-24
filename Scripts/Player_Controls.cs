using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour
{
    public float speed;
    public Vector2 turn;
    public Rigidbody rb;
    public float jumpAmount;
    public float sensitivity;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        speed = 6.0f;
        jumpAmount = 8.0f;
        //Cursor.lockState = CursorLockMode.Locked;
        sensitivity = 3.0f;
    }

    void OnCollisionStay()
    {
        if (!isGrounded && rb.velocity.y == 0)
        {
            isGrounded = true; //jumpsLeft = 1; 
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * Vector3.right * Time.deltaTime *speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetMouseButton(1)) //Right Mouse Button
        {
            turn.x += Input.GetAxis("Mouse X") * sensitivity;
            transform.localRotation = Quaternion.Euler(0, turn.x, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode.Impulse);
            isGrounded = false;
        }

    }
}
