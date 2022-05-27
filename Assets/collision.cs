using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("Player"))
        {
            SceneManager.LoadScene(1);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
