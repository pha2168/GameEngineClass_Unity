using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {
    public void StopTimer() {
        if(TimerCount.stop) {
            TimerCount.stop = false;
        } else {
            TimerCount.stop = true;
        }
    }
}