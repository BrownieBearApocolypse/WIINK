using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public GameObject Button;
    public bool Triggered;
    public float timecount = 0.8f;
    public float Timeinactive = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Triggered = false;
    }

    private void Update()
    {
        timecount += Time.deltaTime;
    }


    public void OnTriggerEnter2D (Collider2D other)
    {
        if (Triggered == false && other.gameObject.tag == "Player" && timecount == 0)
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
