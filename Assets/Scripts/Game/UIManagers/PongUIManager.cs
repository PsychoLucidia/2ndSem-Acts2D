using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PongUIManager : MonoBehaviour
{
    public GameObject IngameUIObj;
    public GameObject ball;

    void Start()
    {
    }

    public void RicoLevelComplete()
    {
        ball.SetActive(false);
        IngameUIObj.SetActive(false);
        Time.timeScale = 0;
    }

    public void GameOver()
    {
        ball.SetActive(false);
        IngameUIObj.SetActive(false);
        Time.timeScale = 0;
    }

}
