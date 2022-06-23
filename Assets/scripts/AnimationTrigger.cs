using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public GameObject Button;
    public bool Triggered;
 

    // Start is called before the first frame update
    void Update()
    {
        Triggered = false;
    }

   //use aniamtion events to track time 


    public void OnTriggerEnter2D (Collider2D other)
    {
        if (Triggered == false && other.gameObject.tag == "Player")
        {
            Triggered = true;
            Button.GetComponent<Animator>().SetTrigger("ButtonPress");
            //Debug.Log("it works");
            
        }
    }

   

    
}
