using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity;
    public float minRotation;
    public float maxRotation;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        sensitivity = 3.0f;
        minRotation = -90.0f;
        maxRotation = 90.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1)) //Right Mouse Button
        {
            turn.y += Input.GetAxis("Mouse Y") * sensitivity;

            if (turn.y > 90)
            {
                turn.y = turn.y - (turn.y - 90);
            }
            else if(turn.y < -90)
            {
                turn.y = turn.y + ((turn.y + 90) * -1);
            }
            else
            {
                turn.y = turn.y;
            }

            float yPos = Mathf.Clamp(turn.y, minRotation, maxRotation);
            transform.localRotation = Quaternion.Euler(-yPos, 0, 0);
        }
    }
}
