using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HiyokoCreator : MonoBehaviour
{
    public GameObject obj;
    public float interval = 3;
    private float time;
    void Update() {
        time += Time.deltaTime; // �ǽð� ����
        if(time >= interval) {
            time = 0;
            GameObject hiyoko = Instantiate(obj) as GameObject;
            Score.score++;
        }
    }
}
