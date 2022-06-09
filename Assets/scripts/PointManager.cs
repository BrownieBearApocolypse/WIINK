using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public static PointManager instance { get; private set; }
    public float score;
    public float pointsPerCollectable = 1;



    private void Awake()
    {
        DontDestroyOnLoad(this);
        instance = this;
    }

    public void IncreaseScore(float amount)
    {
        score += amount;
    }


}
