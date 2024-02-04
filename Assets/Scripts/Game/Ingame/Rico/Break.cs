using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D onHit)
    {
        if (onHit.gameObject.CompareTag("Ball"))
        {
            Destroy(this.gameObject);
        }
    }
}
