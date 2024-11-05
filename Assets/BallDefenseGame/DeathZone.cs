using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag == "Hiyoko") {
            UIController.gameOver = true;
        }
    }
}
