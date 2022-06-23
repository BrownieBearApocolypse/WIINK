using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public GameObject Button;
    public bool Triggered = false;
 

 
   //use aniamtion events to track time 


    public void OnTriggerEnter2D (Collider2D other)
    {
        Triggered = true;
        if (Triggered == true && other.gameObject.tag == "Player")
        {
            Button.GetComponent<Animator>().SetTrigger("ButtonPress");
            Debug.Log("it works");
        }
    }

    public void AnimationEnd()
    {
        Triggered = false;
        Debug.Log("False");
    }

}
