using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SpawnPaperBall : MonoBehaviour
{
    public GameObject paperBall;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnBall()
    {
        //GameObject spawnedBall = Instantiate(paperBall);
        paperBall.SetActive(true);
        paperBall.GetComponent<Rigidbody>().position = spawnPoint.position;
        paperBall.GetComponent<Rigidbody>().velocity = Vector3.zero;
        paperBall.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
