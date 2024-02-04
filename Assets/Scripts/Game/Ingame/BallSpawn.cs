using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject[] ball = new GameObject[0];

    public bool spawnLeft = false;
    public bool spawnRight = false;

    public Transform paddleLeft;
    public Transform paddleRight;

    void Start()
    {
        paddleLeft = GameObject.Find("P1Spawn").GetComponent<Transform>();
        paddleRight = GameObject.Find("P2Spawn").GetComponent<Transform>();

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

    public void respawnBallPlayer()
    {
        GameObject createdBall;
        createdBall = Instantiate(ball[1]);
        if(spawnLeft)
        {
            createdBall.transform.position = paddleLeft.position;
        }
        else if (spawnRight)
        {
            createdBall.transform.position = paddleRight.position;
        }
    }

    public bool checkSpawnLeft()
    {
        return spawnLeft;
    }

    public bool checkSpawnRight()
    {
        return spawnRight;
    }

    public void spawnLeftFalseBool()
    {   
        spawnLeft = false;
    }

    public void spawnRightFalseBool()
    {
        spawnRight = false;
    }

    public void spawnLeftTrueBool()
    {
        spawnLeft = true;
    }

    public void spawnRightTrueBool()
    {
        spawnRight = true;
    }

}
