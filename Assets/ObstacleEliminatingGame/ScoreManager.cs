using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI 관련 기능 사용시 필요

public class ScoreManager : MonoBehaviour
{
    private Text scoreText;
    private int count;
    void Start()
    {
        GameObject scoreObj = GameObject.Find("Score");
        this.scoreText = scoreObj.GetComponent<Text>(); // Text object 찾기
        count = 0; // 점수 초기화
    }
    public void incScore()
    {
        count += 1;
        this.scoreText.text = count.ToString(); // 숫자를 문자열로 변환 후 Text에 지정
    }
}
