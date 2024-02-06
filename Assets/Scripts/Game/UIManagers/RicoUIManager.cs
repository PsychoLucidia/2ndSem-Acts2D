using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RicoUIManager : MonoBehaviour
{
    public GameObject ricoUiObj;
    public GameObject gameOverObj;
    public GameObject lvlCmpeteObj;
    public GameObject ball;

    void Start()
    {
        lvlCmpeteObj.SetActive(false);
        gameOverObj.SetActive(false);
    }

    public void RicoLevelComplete()
    {
        lvlCmpeteObj.SetActive(true);
        ball.SetActive(false);
        ricoUiObj.SetActive(false);
        Time.timeScale = 0;
    }

    public void GameOver()
    {
        gameOverObj.SetActive(true);
        ball.SetActive(false);
        ricoUiObj.SetActive(false);
        Time.timeScale = 0;
    }

}
