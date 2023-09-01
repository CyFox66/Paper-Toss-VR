using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ScoreCollision : MonoBehaviour
{
    [SerializeField]
    public string objectTag;

    public Scoring scoreBoard;

    private bool canScore;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(objectTag))
        {
            StartCoroutine(ScoreWithDelay());
        }
    }

    private IEnumerator ScoreWithDelay()
    {
        canScore = false;

        scoreBoard.AddScore(1);

        yield return new WaitForSeconds(1f);

        canScore = true;
    }
}
