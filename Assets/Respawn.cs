using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Respawn : MonoBehaviour { 
 float threshold = -6f;
    //Use this for initialization
    void Start () {

}

//Update is called once per frame
void Update() {
    if (transform.position.y < threshold)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
} 
