using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class SceneActivator : MonoBehaviour
{
    public string sceneName;
    public bool isActive;
    public GameObject XROrigin;
    public Transform sceneSpawn;
    public string[] objectTags;

    public void ActivateScene()
    {
        isActive = true;
        if (sceneSpawn != null)
        {
            XROrigin.transform.position = sceneSpawn.position;
            XROrigin.transform.rotation = sceneSpawn.rotation;

            Debug.Log("Activated Scene");
        }
        else
        {
            Debug.LogWarning("No mainMenuSpawn assigned");
        }
    }
    public void DeactivateScene()
    {
        isActive = false;
    }

    void OnTriggerStay(Collider other)
    {
        //Debug.Log(sceneName + ": Collider Detected");
        foreach (string tag in objectTags)
        {
            if (other.CompareTag(tag))
            {
            
                //Debug.Log(sceneName + ": Found Tag");
                if (isActive)
                {
                    //Debug.Log(sceneName + ": isActive");
                    SceneBasedDeactivation deactivator = other.gameObject.GetComponent<SceneBasedDeactivation>();
                    if (deactivator != null)
                    {
                        //Debug.Log(sceneName + ": Activated Object");
                        deactivator.ActivateObject();
                    }
                }
                else
                {
                    //Debug.Log(sceneName + ": deActive");
                    SceneBasedDeactivation deactivator = other.gameObject.GetComponent<SceneBasedDeactivation>();
                    if (deactivator != null)
                    {
                        //Debug.Log(sceneName + ": Deactivated Object");
                        deactivator.DeactivateObject();
                    }
                }
            }
        }
    }
}
