using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // OnGUI�� ����ϱ� ���� �ʿ�
public class TimerUI : MonoBehaviour
{
    float curTime = 0f;
    string timerText;

    GUIStyle guiStyle = new GUIStyle();
    void OnGUI()
    {
        guiStyle.fontSize = 40;
        guiStyle.normal.textColor = Color.red;
        string timerText = "Timer : " + (int)curTime;
        Rect textPos = new Rect(100, 100, 200, 40);
        GUI.Label(textPos, timerText, guiStyle);
    }

    void Update()
    {
        curTime += Time.deltaTime; // �ǽð� ����
    }


}
