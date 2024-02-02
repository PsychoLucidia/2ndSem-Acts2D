using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject[] ball = new GameObject[0];

    void Start()
    {
        GameObject createdBall;
        createdBall = Instantiate(ball[0]);
        createdBall.transform.position = transform.position;
    }

    public void destroyBall()
    {
        GameObject[] balled = GameObject.FindGameObjectsWithTag("Ball");

        foreach(GameObject bals in balled)
        {
            Destroy(bals);
        }
    }

    public void spawnBall()
    {
        GameObject createdBall;
        createdBall = Instantiate(ball[0]);
        createdBall.transform.position = transform.position;
    }
}
