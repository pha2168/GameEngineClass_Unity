using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // 좌클릭 되었으면
            SceneManager.LoadScene("ball"); // Main scene 이동
        }
    }
    private GUIStyle guiStyle = new GUIStyle(); // Font의 style(크기, 색상 등) 변경을 위해 필요
    void OnGUI()
    {
        guiStyle.fontSize = 40; // Font size 변경
        guiStyle.normal.textColor = Color.red; // Font color 변경
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 128, 32), "ball", guiStyle); // 화면 중간에 text 표시
    }
}
