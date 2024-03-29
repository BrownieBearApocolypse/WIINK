using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDestory : MonoBehaviour
{
    //when player hits the point game object, it adds a int data to the game manager and point manager scripts
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            PointManager.Instance.totalScore += PointManager.Instance.pointsPerCollectable;
            PointManager.Instance.IncreaseScore(PointManager.Instance.totalScore);
            GameManager.Instance.score += GameManager.Instance.lvlScore;
            GameManager.Instance.IncreaseScore(GameManager.Instance.score);
            //Debug.Log("GOtEm");
        }
    }
}
