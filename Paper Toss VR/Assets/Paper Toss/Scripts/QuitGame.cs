using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void QuitGameCommand()
    {
        // Quit the application (only works in standalone builds, not in the Unity Editor)
        Application.Quit();
    }
}
