using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Controller : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    private Animator animator;
    public WinLose winLoseScript;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //enemyRun();
    }

    public void enemyRun()
    {
        if (!animator.GetBool("onPlatform")) //if returns false
        {
            animator.SetBool("onPlatform", true);
            enemy.SetDestination(player.position);
        }
        else 
        {
            animator.SetBool("onPlatform", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        winLoseScript.loseLevel();
    }
}
