using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakAniTween : MonoBehaviour
{
    public Transform brickAni;
    public SpriteRenderer brickColor;
    void Start()
    {
        LeanTween.scale(brickAni.gameObject, new Vector3(0f, 10f, 1f), 0.2f).setIgnoreTimeScale(true);
        LeanTween.color(brickColor.gameObject, new Color(255f, 255f, 255f, 0f), 0.2f).setIgnoreTimeScale(true);
        StartCoroutine(enumerator());
    }

    IEnumerator enumerator()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        Destroy(this.gameObject);
    }
}
