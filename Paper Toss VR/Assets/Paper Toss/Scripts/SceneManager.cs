using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject XROrigin;
    public Transform mainMenuSpawn;
    public Transform level0Spawn;
    public Transform level1Spawn;
    public Transform level2Spawn;
    public Transform level3Spawn;
    public Transform level4Spawn;
    public Transform level5Spawn;
    public Transform level6Spawn;
    public Transform infiniteSpawn;
    public Transform timedSpawn;

    public void GoToMainMenu()
    {
        if (mainMenuSpawn != null)
        {
            XROrigin.transform.position = mainMenuSpawn.position;
            XROrigin.transform.rotation = mainMenuSpawn.rotation;
        }
        else
        {
            Debug.LogWarning("No mainMenuSpawn assigned");
        }
    }

    public void GoToLevel0()
    {
        if (level0Spawn != null)
        {
            XROrigin.transform.position = level0Spawn.position;
            XROrigin.transform.rotation = level0Spawn.rotation;
        }
        else
        {
            Debug.LogWarning("No level0Spawn assigned");
        }
    }

    public void GoToLevel1()
    {
        if (level1Spawn != null)
        {
            XROrigin.transform.position = level1Spawn.position;
            XROrigin.transform.rotation = level1Spawn.rotation;
        }
        else
        {
            Debug.LogWarning("No level1Spawn assigned");
        }
    }

    public void GoToLevel2()
    {
        if (level2Spawn != null)
        {
            XROrigin.transform.position = level2Spawn.position;
            XROrigin.transform.rotation = level2Spawn.rotation;
        }
        else
        {
            Debug.LogWarning("No level2Spawn assigned");
        }
    }

    public void GoToLevel3()
    {
        if (level2Spawn != null)
        {
            XROrigin.transform.position = level3Spawn.position;
            XROrigin.transform.rotation = level3Spawn.rotation;
        }
        else
        {
            Debug.LogWarning("No level3Spawn assigned");
        }
    }

    public void GoToLevel4()
    {
        if (level2Spawn != null)
        {
            XROrigin.transform.position = level4Spawn.position;
            XROrigin.transform.rotation = level4Spawn.rotation;
        }
        else
        {
            Debug.LogWarning("No level4Spawn assigned");
        }
    }

    public void GoToLevel5()
    {
        if (level2Spawn != null)
        {
            XROrigin.transform.position = level5Spawn.position;
            XROrigin.transform.rotation = level5Spawn.rotation;
        }
        else
        {
            Debug.LogWarning("No level5Spawn assigned");
        }
    }

    public void GoToLevel6()
    {
        if (level2Spawn != null)
        {
            XROrigin.transform.position = level6Spawn.position;
            XROrigin.transform.rotation = level6Spawn.rotation;
        }
        else
        {
            Debug.LogWarning("No level6Spawn assigned");
        }
    }
    public void GoToInfinite()
    {
        if (infiniteSpawn != null)
        {
            XROrigin.transform.position = infiniteSpawn.position;
            XROrigin.transform.rotation = infiniteSpawn.rotation;
        }
        else
        {
            Debug.LogWarning("No infiniteSpawn assigned");
        }
    }

    public void GoToTimed()
    {
        if (timedSpawn != null)
        {
            XROrigin.transform.position = timedSpawn.position;
            XROrigin.transform.rotation = timedSpawn.rotation;
        }
        else
        {
            Debug.LogWarning("No timedSpawn assigned");
        }
    }
}
