using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperBallAutoSpawn : MonoBehaviour
{
    [SerializeField]
    public string objectTag;

    public SpawnPaperBall Spawner;

    private bool canSpawn = true;

    void OnTriggerExit(Collider other)
    {
        if (canSpawn && other.CompareTag(objectTag))
        {
            StartCoroutine(SpawnWithDelay());
        }
    }
    
    private IEnumerator SpawnWithDelay()
    {
        canSpawn = false;

        yield return new WaitForSeconds(.4f);

        Spawner.SpawnBall();

        yield return new WaitForSeconds(1f);

        canSpawn = true;
    }
}
