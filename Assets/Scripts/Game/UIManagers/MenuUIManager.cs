using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject ricoLevelSelect;

    void Start()
    {
        Time.timeScale = 1;

        mainMenu.SetActive(true);
        ricoLevelSelect.SetActive(false);
    }

    public void GoToRicoSelect()
    {
        mainMenu.SetActive(false);
        ricoLevelSelect.SetActive(true);
    }

    public void GoToMainMenu()
    {
        mainMenu.SetActive(true);
        ricoLevelSelect.SetActive(false);
    }
}

