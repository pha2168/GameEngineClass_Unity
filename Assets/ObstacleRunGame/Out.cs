using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Out : MonoBehaviour {
    void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag == "Player") {
            SceneManager.LoadScene("ObstacleRunGame");
        }
    }
}
