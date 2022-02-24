using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public WinLose winLoseScript;

    private void OnTriggerEnter(Collider other)
    {
        winLoseScript.loseLevel();
    }
}
