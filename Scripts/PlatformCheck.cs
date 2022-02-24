using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCheck : MonoBehaviour
{
    public Enemy_Controller enemy1;
    public Enemy_Controller enemy2;
    public Enemy_Controller enemy3;
    public Enemy_Controller enemy4;
    public bool isTouched;

    void Start()
    {
        isTouched = false;
    }

    void Update()
    {
        if (isTouched == true)
        {
            enemy1.enemyRun();
            enemy2.enemyRun();
            enemy3.enemyRun();
            enemy4.enemyRun();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        isTouched = true;
        //Debug.Log("Touched platform.");
    }

    void OnCollisionExit(Collision collision)
    {
        isTouched = false;
        //Debug.Log("Left platform.");
    }
}
