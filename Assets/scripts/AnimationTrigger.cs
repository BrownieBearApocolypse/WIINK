using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public GameObject Button;
    public bool Triggered;

    // Start is called before the first frame update
    void Start()
    {
        Triggered = false;
    }

    // Update is called once per frame


    public void OnTriggerEnter2D (Collider2D other)
    {
        if (Triggered == false && other.gameObject.tag == "Player")
        {
            Triggered = true;
            Button.GetComponent<Animator>().SetTrigger("ButtonPress");
            //Debug.Log("it works");
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        Triggered = false;
    }
}
