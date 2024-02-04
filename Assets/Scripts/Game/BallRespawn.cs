using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallRespawn : MonoBehaviour
{
    public float speed; //ball's movement speed
    public Rigidbody2D ballRB; //reference to the rb2d component

    private BallSpawn ballSpawn;

    void Start()
    {
        //Attaching necessary components upon start
        ballRB = GetComponent<Rigidbody2D>();
        ballSpawn = GameObject.Find("BallSpawn").GetComponent<BallSpawn>();

        if(ballSpawn.checkSpawnLeft() == true)
        {
            /*Debug.Log("Spawn Left");*/
            ballRB.velocity = Vector2.right * speed;
            ballSpawn.spawnLeftFalseBool();
        }
        else if (ballSpawn.checkSpawnRight() == true)
        {
            /*Debug.Log("Spawn Right");*/
            ballRB.velocity = Vector2.left * speed;
            ballSpawn.spawnRightFalseBool();
        }
    }

    private void OnCollisionEnter2D(Collision2D actor)
    {
        if (actor.gameObject.name == "Player1")
        {
            float y = calculatePosition(transform.position, actor.transform.position, actor.collider.bounds.size.y);
            Vector2 direction = new Vector2(1, y).normalized;
            ballRB.velocity = direction * speed;
        }

        if (actor.gameObject.name == "Player2")
        {
            float y = calculatePosition(transform.position, actor.transform.position, actor.collider.bounds.size.y);
            Vector2 direction = new Vector2(-1, y).normalized;
            ballRB.velocity = direction * speed;
        }
    }

    float calculatePosition(Vector2 ballPosition, Vector2 panelPosition, float panelHeight)
    {
        float value = (ballPosition.y - panelPosition.y) / panelHeight;
        return value;
    }
}
