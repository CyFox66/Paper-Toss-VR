using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ScoreCollision : MonoBehaviour
{
    public Scoring scoreBoard;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            scoreBoard.AddScore(1);
        }
    }
}
