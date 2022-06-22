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
            PointManager.Instance.totalScore += PointManager.Instance.pointsPerCollectable;
            PointManager.Instance.IncreaseScore(PointManager.Instance.totalScore);
            
            //Debug.Log("GOtEm");
        }
    }
}
