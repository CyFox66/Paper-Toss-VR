using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ScoreCollision : MonoBehaviour
{
    public string objectTag;
    public Scoring scoreBoard;
    public GameObject scoringParticles;
    public GameObject trashBin;

    private bool canScore = true;

    private void Awake()
    {
        if (trashBin.GetComponent<RandomTeleport>() != null)
        {
            trashBin.GetComponent<RandomTeleport>().TeleportRandomly(trashBin);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (canScore && other.CompareTag(objectTag))
        {
            other.gameObject.SetActive(false);
            StartCoroutine(ScoreWithDelay());
        }
    }

    private IEnumerator ScoreWithDelay()
    {
        canScore = false;

        if(scoreBoard != null)
        {
            scoreBoard.AddScore(1);
        }
        
        //GameObject particleSystemObject = Instantiate(scoringParticles, transform.position, Quaternion.identity);
        //ParticleSystem particleSystem = particleSystemObject.GetComponent<ParticleSystem>();
        
        scoringParticles.SetActive(true);
        
        ParticleSystem particleSystem = scoringParticles.GetComponent<ParticleSystem>();
        
        if (particleSystem != null)
        {
            particleSystem.Play();
        }

        yield return new WaitForSeconds(2f);

        if (particleSystem != null)
        {
            particleSystem.Stop();
        }
        
        scoringParticles.SetActive(false);

        yield return new WaitForSeconds(.5f);

        if (trashBin.GetComponent<RandomTeleport>() != null)
        {
            trashBin.GetComponent<RandomTeleport>().TeleportRandomly(trashBin);
        }
        canScore = true;
    }
}
