 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TerrainTools;

public class Break : MonoBehaviour
{
    public GameManager gameManager;

    public static int brickCount = 0;
    public int brickHealth = 1;
    public SpriteRenderer spriteRenderer;


    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        BrickColor();

        brickCount++;
    }

    public void OnCollisionEnter2D(Collision2D onHit)
    {
        if (onHit.gameObject.CompareTag("Ball"))
        {
            DestroyObject();
            BrickColor();
            Debug.Log("Brick Count: " + brickCount.ToString());
        }
    
    }

    public void DestroyObject()
    {
        brickHealth--;

        if (brickHealth < 1)
        {
            brickCount--;
            Destroy(this.gameObject);
        }

        if (brickCount <= 0)
        {
            gameManager.brickCheck = true;
        }

    }

    private void BrickColor()
    {
        switch (brickHealth)
        {
            case 1: spriteRenderer.color = new Color(255f, 255f, 255f, 255f); break;
            case 2: spriteRenderer.color = new Color(255f, 183f, 0f, 255f); break;
            case 3: spriteRenderer.color = new Color(255f, 0f, 0f, 255f); break;
            default: spriteRenderer.color = new Color(255f, 255f, 255f, 255f); break;
        }
    }

    void Update()
    {

    }
}
