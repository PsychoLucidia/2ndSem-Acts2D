using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public GameManager gameManager;
    public BallSpawn ballSpawn; 
    public PlayerController playerController;
    public PlayerController playerController2;


    public int checkWall;
    private bool checkWin = false;

    void Start()
    {
        ballSpawn = GameObject.Find("BallSpawn").GetComponent<BallSpawn>();
        playerController = GameObject.Find("Player1").GetComponent<PlayerController>();
        playerController2 = GameObject.Find("Player2").GetComponent<PlayerController>();
    }

    public void OnCollisionEnter2D(Collision2D wall)
    {
        if(wall.gameObject.CompareTag("Ball"))
        {
            switch (checkWall)
            {
                case 1:
                    gameManager.p1Score += 1;
                    ballSpawn.destroyBall();
                    StartCoroutine(respawnBall());
                    ballSpawn.spawnRightTrueBool();
                    break;

                case 2:
                    gameManager.p2Score += 1;
                    ballSpawn.destroyBall();
                    StartCoroutine(respawnBall());
                    ballSpawn.spawnLeftTrueBool();
                    break;
            }
        }
    }

    void Update()
    {
        if(checkWin)
        {
            return;
        }

        if(gameManager.p1Score >= 10)
        {
            
        }

        else if(gameManager.p2Score > 10)
        {

        }

    }

    IEnumerator respawnBall()
    {
        yield return new WaitForSecondsRealtime(1f);
        ballSpawn.spawnBall();
    }
}
