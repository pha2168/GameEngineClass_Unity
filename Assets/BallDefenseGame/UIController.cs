using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text text;
    public static bool gameOver;
    public GameObject button;
    // GameOver �ؽ�Ʈ�� ��ư �����
    void Start() {
        text.enabled = false;
        button.SetActive(false);
    }
    // GameOver �ؽ�Ʈ�� ��ư ǥ��
    void Update() {
        if(gameOver) {
            text.enabled = true;
            button.SetActive(true);
        }
    }
}
