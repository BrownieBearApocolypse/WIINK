using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject player;
    public Transform Platform;

    private void OnCollisionEnter2D(Collision2D other)
    {
      player.transform.SetParent(Platform, true);
       
    }

    private void OnCollisionExit2D(Collision2D other)
    {
       player.transform.SetParent(null);
       
    }
}
