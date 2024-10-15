using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // ��Ŭ�� �Ǿ�����
            SceneManager.LoadScene("ball"); // Main scene �̵�
        }
    }
    private GUIStyle guiStyle = new GUIStyle(); // Font�� style(ũ��, ���� ��) ������ ���� �ʿ�
    void OnGUI()
    {
        guiStyle.fontSize = 40; // Font size ����
        guiStyle.normal.textColor = Color.red; // Font color ����
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 128, 32), "ball", guiStyle); // ȭ�� �߰��� text ǥ��
    }
}
