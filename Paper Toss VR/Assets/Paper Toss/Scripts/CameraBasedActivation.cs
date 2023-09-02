using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBasedActivation : MonoBehaviour
{
    private Camera mainCamera;
    public LayerMask layerMask; // Optionally, you can specify a layer mask for the raycast

    private void Start()
    {
        mainCamera = Camera.main;

        if (mainCamera == null)
        {
            Debug.LogError("Main camera not found in the scene.");
        }
    }

    private void Update()
    {
        if (mainCamera == null)
        {
            return;
        }

        // Get all objects with the specified tag (e.g., "YourTag")
        GameObject[] objectsToActivate = GameObject.FindGameObjectsWithTag("Prop");

        //Debug.Log("Found " + objectsToActivate.Length + " props");

        foreach (var obj in objectsToActivate)
        {
            // Check if the object's renderer is within the camera's view
            Renderer[] childRenderers = obj.GetComponentsInChildren<Renderer>();

            foreach(Renderer renderer in childRenderers)
            {
                if (renderer != null && IsVisibleFromCamera(renderer, mainCamera))
                {
                    // Activate the object
                    foreach(Transform transform in obj.transform)
                    {
                        transform.gameObject.SetActive(true);
                    }
                }
            }
        }
    }

    // Check if a renderer is visible from a camera's view
    private bool IsVisibleFromCamera(Renderer renderer, Camera camera)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);

        return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
    }
}
