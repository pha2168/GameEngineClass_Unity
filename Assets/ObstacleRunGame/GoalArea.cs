using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalArea : MonoBehaviour
{
    public static bool goal; // static으로 선언시 다른 script에서 참조 가능
    void Start() {
        goal = false;
    }
    void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag == "Player") {
            goal = true;
        }
    }
}
