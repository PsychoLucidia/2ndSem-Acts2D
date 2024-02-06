using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    public void selectGame(int dictateScene)
    {
        SceneManager.LoadSceneAsync(dictateScene);
    }

    public void RicoSelectLevel(int dictateScene)
    {
        Break.brickCount = 0;
        Debug.Log("Brick count set to " + Break.brickCount.ToString());
        SceneManager.LoadSceneAsync(dictateScene);
    }

    public void retryBtn()
    {
        Break.brickCount = 0;
        SceneManager.LoadSceneAsync(currentSceneNum());
    }

    public void nextLvlBtn()
    {
        int currentScene = currentSceneNum() + 1;
        if (currentScene > 4)
        {
            SceneManager.LoadSceneAsync(0);
        }
        else
        {
            SceneManager.LoadSceneAsync(currentScene);
        }

    }

    private int currentSceneNum()
    {
        int curNum = SceneManager.GetActiveScene().buildIndex;
        return curNum;
    }
}
