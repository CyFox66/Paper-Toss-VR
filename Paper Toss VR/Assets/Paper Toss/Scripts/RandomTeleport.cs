using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTeleport : MonoBehaviour
{
    public BoxCollider teleportArea; // Reference to the Box Collider defining the teleport area

    public void TeleportRandomly(GameObject objectToTeleport)
    {
        if (teleportArea == null)
        {
            Debug.LogError("Teleport area (Box Collider) is not assigned.");
            return;
        }

        // Get the bounds of the teleport area
        Bounds bounds = teleportArea.bounds;

        // Generate random coordinates within the bounds of the teleport area
        float randomX = Random.Range(bounds.min.x, bounds.max.x);
        float y = bounds.min.y;
        float randomZ = Random.Range(bounds.min.z, bounds.max.z);

        // Create a new position vector with the random coordinates
        Vector3 randomPosition = new Vector3(randomX, y, randomZ);

        // Teleport the object to the random position
        objectToTeleport.transform.position = randomPosition;
    }
}
