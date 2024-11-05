using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text text;
    public static bool gameOver;
    public GameObject button;
    // GameOver 텍스트와 버튼 지우기
    void Start() {
        text.enabled = false;
        button.SetActive(false);
    }
    // GameOver 텍스트와 버튼 표시
    void Update() {
        if(gameOver) {
            text.enabled = true;
            button.SetActive(true);
        }
    }
}
