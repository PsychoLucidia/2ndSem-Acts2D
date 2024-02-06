using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseUI : MonoBehaviour
{
    public bool isPauseOpen = false;
    public bool isCoroutineRunning = false;

    public GameObject pauseMainUIObj;

    public GameObject IngameUIObj;
    
    void Start()
    {
        pauseMainUIObj.SetActive(false);
        IngameUIObj.SetActive(true);
    }

    public void openPauseUI()
    {
        pauseMainUIObj.SetActive(true);
        IngameUIObj.SetActive(false);
        isPauseOpen = true;
    }

    public void closePauseUI()
    {
        pauseMainUIObj.SetActive(false);

        isCoroutineRunning = true;
        StartCoroutine(closePauseUIDel());
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPauseOpen && !isCoroutineRunning)
            {
                openPauseUI();
                Time.timeScale = 0;
            }
            else 
            {
                closePauseUI();
            }
        }
    }

    IEnumerator closePauseUIDel()
    {
        yield return new WaitForSecondsRealtime(1f);
        IngameUIObj.SetActive(true);
        isCoroutineRunning = false;
        isPauseOpen = false;
        Time.timeScale = 1;
    }
}
