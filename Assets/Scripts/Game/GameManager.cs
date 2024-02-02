using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public string levelName;

    public int p1Score;
    public int p2Score;

    public TextMeshProUGUI txtP1Score;
    public TextMeshProUGUI txtP2Score;

    public bool brickCheck;
    public TextMeshProUGUI txtMessage;

    void Update()
    {
        if (levelName == "Pong")
        {
            txtP1Score.text = p1Score.ToString(); //this displays the value on screen by converting the int variables to string
            txtP2Score.text = p2Score.ToString();
        }
    }
}

