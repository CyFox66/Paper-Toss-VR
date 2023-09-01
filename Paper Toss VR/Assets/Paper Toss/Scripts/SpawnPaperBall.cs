using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SpawnPaperBall : MonoBehaviour
{
    public GameObject paperBall;
    public Transform spawnPoint;

    public void SpawnBall()
    {
        GameObject spawnedBall = Instantiate(paperBall);
        spawnedBall.GetComponent<Rigidbody>().position = spawnPoint.position;
    }

    public void SpawnBallToHand(UnityEngine.Object eventDataObject)
    {
        Debug.Log("SpawnBall Method Called.");
        if (eventDataObject is XRBaseInteractor handInteractor)
        {
            Debug.Log("EventData is XRBaseInteractor");
            // Instantiate the paper ball at a certain position (can be set to the hand's position)
            GameObject newPaperBall = Instantiate(paperBall, handInteractor.transform.position, Quaternion.identity);

            // Attach the paper ball to the hand's attachTransform
            newPaperBall.GetComponent<XRGrabInteractable>().attachTransform = handInteractor.attachTransform;

            // Enable the paper ball's interaction
            newPaperBall.GetComponent<XRGrabInteractable>().enabled = true;
        }
        else
        {
            Debug.LogWarning("SpawnBall method called with incorrect parameter type");
        }
    }
}
