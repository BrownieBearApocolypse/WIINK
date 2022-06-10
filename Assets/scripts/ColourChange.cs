using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    public Collider2D Collider;

    public void EventMet()
    {
        Collider.enabled = false;               
    }
    
    public void EventOver()
    {
        Collider.enabled = true;
    }
}
