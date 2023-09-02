using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnTagCount : MonoBehaviour
{
    public string tagToCount; // Specify the tag you want to count
    public int maxCount; // Specify the maximum count before destroying an object
    public string scene;

    void Start()
    {
        int count = CountObjectsWithTag(tagToCount);
        Debug.Log("Number of objects with tag '" + tagToCount + "' in " + scene + ": " + count);
    }
    void Update()
    {
        int count = CountObjectsWithTag(tagToCount);

        if (count >= maxCount)
        {
            DestroyOneObjectWithTag(tagToCount);
        }
    }

    int CountObjectsWithTag(string tag)
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tag);
        return taggedObjects.Length;
    }

    void DestroyOneObjectWithTag(string tag)
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tag);
        if (taggedObjects.Length > 0)
        {
            //int randomIndex = Random.Range(0, taggedObjects.Length);
            Destroy(taggedObjects[0]);
            Debug.Log("Destroyed one object with tag '" + tag + "' in " + scene);
        }
    }
}
