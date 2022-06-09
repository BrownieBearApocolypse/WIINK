using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDestory : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            PointManager.instance.Score += PointManager.instance.pointsPerCollectable;
            PointManager.instance.IncreaseScore(PointManager.instance.Score);
        }
    }
}
