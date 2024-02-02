using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnerMove : MonoBehaviour
{
    private Transform spawnerMove;
    void Start()
    {
        spawnerMove = GameObject.Find("BallSpawn").GetComponent<Transform>();
        spawnerMove.position = new Vector3(0, 0, 0);
        LeanTween.moveY(spawnerMove.gameObject, 3, 0.5f);
        StartCoroutine(StartLoop());
    }

    void StartMove()
    {
        LeanTween.moveY(spawnerMove.gameObject, -3, 0.5f).setLoopPingPong().setRepeat(-1).setIgnoreTimeScale(true);
    }

    IEnumerator StartLoop()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        StartMove();
    }
}
