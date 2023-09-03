using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public SceneActivator mainMenu;
    public SceneActivator infiniteMode;
    public SceneActivator timedMode;
    public SceneActivator level0;
    public SceneActivator level1;
    public SceneActivator level2;
    public SceneActivator level3;
    public SceneActivator level4;
    public SceneActivator level5;
    public SceneActivator level6;
    public GameObject gameMenu;

    public void GoToMainMenu()
    {
        if (mainMenu != null)
        {
            foreach (Transform child in gameMenu.transform)
            {
                child.gameObject.SetActive(false);
            }
            if (infiniteMode != null)
            {
                infiniteMode.DeactivateScene();
            }
            if (timedMode != null)
            {
                timedMode.DeactivateScene();
            }
            if (level0 != null)
            {
                level0.DeactivateScene();
            }
            if (level1 != null)
            {
                level1.DeactivateScene();
            }
            if (level2 != null)
            {
                level2.DeactivateScene();
            }
            if (level3 != null)
            {
                level3.DeactivateScene();
            }
            if (level4 != null)
            {
                level4.DeactivateScene();
            }
            if (level5 != null)
            {
                level5.DeactivateScene();
            }
            if (level6 != null)
            {
                level6.DeactivateScene();
            }
            Debug.Log("Loaded Main Menu");
            mainMenu.ActivateScene();
        }
        else
        {
            Debug.LogWarning("No Main Menu Assigned");
        }
    }

    public void GoToInfinite()
    {
        if (infiniteMode != null)
        {
            mainMenu.DeactivateScene();
            Debug.Log("Loaded Infinite Mode");
            infiniteMode.ActivateScene();
        }
        else
        {
            Debug.LogWarning("No infiniteSpawn assigned");
        }
    }

    public void GoToTimed()
    {
        if (timedMode != null)
        {
            mainMenu.DeactivateScene();
            Debug.Log("Loaded Timed Mode");
            timedMode.ActivateScene();
        }
        else
        {
            Debug.LogWarning("No timedSpawn assigned");
        }
    }

    public void GoToLevel0()
    {
        if (level0 != null)
        {
            mainMenu.DeactivateScene();
            Debug.Log("Loaded Level 0");
            level0.ActivateScene();
        }
        else
        {
            Debug.LogWarning("No level0Spawn assigned");
        }
    }

    public void GoToLevel1()
    {
        if (level1 != null)
        {
            mainMenu.DeactivateScene();
            Debug.Log("Loaded Level 1");
            level1.ActivateScene();
        }
        else
        {
            Debug.LogWarning("No level1Spawn assigned");
        }
    }

    public void GoToLevel2()
    {
        if (level2 != null)
        {
            mainMenu.DeactivateScene();
            Debug.Log("Loaded Level 2");
            level2.ActivateScene();
        }
        else
        {
            Debug.LogWarning("No level2Spawn assigned");
        }
    }

    public void GoToLevel3()
    {
        if (level3 != null)
        {
            mainMenu.DeactivateScene();
            Debug.Log("Loaded Level 3");
            level3.ActivateScene();
        }
        else
        {
            Debug.LogWarning("No level3Spawn assigned");
        }
    }

    public void GoToLevel4()
    {
        if (level4 != null)
        {
            mainMenu.DeactivateScene();
            Debug.Log("Loaded Level 4");
            level4.ActivateScene();
        }
        else
        {
            Debug.LogWarning("No level4Spawn assigned");
        }
    }

    public void GoToLevel5()
    {
        if (level5 != null)
        {
            mainMenu.DeactivateScene();
            Debug.Log("Loaded Level 5");
            level5.ActivateScene();
        }
        else
        {
            Debug.LogWarning("No level5Spawn assigned");
        }
    }

    public void GoToLevel6()
    {
        if (level6 != null)
        {
            mainMenu.DeactivateScene();
            Debug.Log("Loaded Level 6");
            level6.ActivateScene();
        }
        else
        {
            Debug.LogWarning("No level6Spawn assigned");
        }
    }
}
