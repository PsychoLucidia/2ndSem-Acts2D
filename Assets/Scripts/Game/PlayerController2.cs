using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController2 : MonoBehaviour
{
    public float speed;
    public float BoundY;

    public Rigidbody2D playerPanel;

    public BallSpawn ballSpawn;

    public int wcPlayer;

    // Start is called before the first frame update
    void Start()
    {
        playerPanel = GetComponent<Rigidbody2D>();
        ballSpawn = GameObject.Find("BallSpawn").GetComponent<BallSpawn>();

    }

    // Update is called once per frame
    void Update()
    {
        var panelVelocity = playerPanel.velocity;

        if (wcPlayer == 1)
        {
            if (ballSpawn.checkSpawnRight() && Input.GetKey(KeyCode.M))
            {
                ballSpawn.respawnBallPlayer();
            }

            if (Input.GetKey(KeyCode.UpArrow)) //W is pressed
            {
                panelVelocity.y = speed;
            }

            else if (Input.GetKey(KeyCode.DownArrow)) //S is pressed
            {
                panelVelocity.y = -speed;
            }

            else
            {
                panelVelocity.y = 0;
            }

        }

        if (wcPlayer == 2)
        {
            if (ballSpawn.checkSpawnLeft() && Input.GetKey(KeyCode.Keypad1))
            {
                ballSpawn.respawnBallPlayer();
            }
            
            if (Input.GetKey(KeyCode.UpArrow)) //Up is pressed
            {
                panelVelocity.y = speed;
            }

            else if (Input.GetKey(KeyCode.DownArrow)) //Down is pressed
            {
                panelVelocity.y = -speed;
            }
        }

        playerPanel.velocity = panelVelocity;

        var panelPos = transform.position;

        if (panelPos.y > BoundY)
        {
            panelPos.y = BoundY;
        }
        else if (panelPos.y < -BoundY)
        {
            panelPos.y = -BoundY;
        }
        transform.position = panelPos;
    }
}
