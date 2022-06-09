using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform player;
    private GameObject Platform;

    private void OnTriggerEnter2D(Collider2D col)
    {
       if (col.CompareTag("Player"))
       {
            col.gameObject.transform.SetParent(gameObject.transform, true);
       }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            col.gameObject.transform.parent = null;
        }
    }
}
