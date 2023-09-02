using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBasedDeactivation : MonoBehaviour
{
    //private bool isActive = false;

    private void Start()
    {
        this.DeactivateObject();
    }
    /*
    private void Update()
    {
        if (isActive)
        {
            foreach (Transform child in gameObject.transform)
            {
                child.gameObject.SetActive(true);
            }
        }
        else
        {
            foreach (Transform child in gameObject.transform)
            {
                child.gameObject.SetActive(false);
            }
        }
    }
    */
    public void ActivateObject()
    {
        foreach(Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    public void DeactivateObject() 
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }


    /*public float deactivationDistance = 15f; // Set the distance threshold for deactivation

    private Transform playerTransform;

    private void Start()
    {
        // Find the player object by tag (or other means)
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        // Ensure the player object is found
        if (playerObject != null)
        {
            playerTransform = playerObject.transform;
        }
        else
        {
            Debug.LogError("Player object not found. Make sure it has the 'Player' tag.");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (playerTransform == null)
        {
            return; // No player to compare distances
        }

        // Calculate the distance between this object and the player
        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        foreach (Transform child in transform)
        {
            // Check if the distance exceeds the deactivation threshold
            if (distanceToPlayer > deactivationDistance)
            {
                // Deactivate (disable) this GameObject
                child.gameObject.SetActive(false);
            }
            else
            {
                // Activate (enable) this GameObject if it's within the distance threshold
                child.gameObject.SetActive(true);
            }
        }
    } */
}
