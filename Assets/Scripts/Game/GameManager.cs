using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public RicoUIManager ricoUIManager;
    public PongUIManager pongUIManager;

    public string levelName;

    public int p1Score;
    public int p2Score;

    public TextMeshProUGUI txtP1Score;
    public TextMeshProUGUI txtP2Score;

    public bool isGameOver = false;

    public bool brickCheck = false;
    public bool levelCompleteTriggered = false;
    public TextMeshProUGUI txtMessage;

    void Start()
    {
        Time.timeScale = 1;
        switch (levelName)
        {
            case "Pong": pongUIManager = GameObject.Find("PongUI").GetComponent<PongUIManager>(); break;
            case "Rico": ricoUIManager = GameObject.Find("RicoUI").GetComponent<RicoUIManager>(); break;
        }
    }

    void Update()
    {
        if (levelName == "Pong")
        {
            txtP1Score.text = p1Score.ToString(); //this displays the value on screen by converting the int variables to string
            txtP2Score.text = p2Score.ToString();
        }

        if (levelName == "Rico")
        {
            if (brickCheck && !isGameOver)
            {
                if (!levelCompleteTriggered)
                {
                    ricoUIManager.RicoLevelComplete();
                    levelCompleteTriggered = true;
                }
            }
        }
    }
}

