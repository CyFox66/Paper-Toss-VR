using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMonitor : MonoBehaviour
{
    [SerializeField]
    public string firstTag;

    [SerializeField]
    public string secondTag;

    public Scoring scoreBoard;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag(firstTag) && collision.gameObject.CompareTag(secondTag))
        {
            scoreBoard.AddScore(1);
        }
    }
}
