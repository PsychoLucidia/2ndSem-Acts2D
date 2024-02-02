using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public GameManager gameManager;

    public int checkWall;

    public void OnCollisionEnter2D(Collision2D wall)
    {
        if(wall.gameObject.CompareTag("Ball"))
        {
            switch (checkWall)
            {
                case 1:
                    gameManager.p1Score += 1;
                    break;

                case 2:
                    gameManager.p2Score += 1;
                    break;
            }
        }
    }
}
