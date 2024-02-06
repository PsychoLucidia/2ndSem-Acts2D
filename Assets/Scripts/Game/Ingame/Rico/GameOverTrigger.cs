using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public RicoUIManager ricoUIManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        ricoUIManager = GameObject.Find("RicoUI").GetComponent<RicoUIManager>();
    }

    public void OnCollisionEnter2D(Collision2D wallHit)
    {
        if (wallHit.gameObject.CompareTag("Ball"))
        {
            gameManager.isGameOver = true;
            Break.brickCount = 0;
            ricoUIManager.GameOver();
        }
    }
}
