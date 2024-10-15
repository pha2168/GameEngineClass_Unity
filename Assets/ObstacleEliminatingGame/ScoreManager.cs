using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI ���� ��� ���� �ʿ�

public class ScoreManager : MonoBehaviour
{
    private Text scoreText;
    private int count;
    void Start()
    {
        GameObject scoreObj = GameObject.Find("Score");
        this.scoreText = scoreObj.GetComponent<Text>(); // Text object ã��
        count = 0; // ���� �ʱ�ȭ
    }
    public void incScore()
    {
        count += 1;
        this.scoreText.text = count.ToString(); // ���ڸ� ���ڿ��� ��ȯ �� Text�� ����
    }
}
