using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab 정보를 지정
    private float timeCount = 0.0f; // 현재 시간
    void Update()
    {
        float xPos = Random.Range(-5.0f, 5.0f);
        Vector3 randomPos = new Vector3(xPos, 1.0f, 4.0f);
        if (timeCount > 5.0f)
        {
            Instantiate(enemyPrefab, randomPos, transform.rotation); // 생성할 위치와 방향
            timeCount = 0.0f;
        }
        timeCount += Time.deltaTime; // 시간의 흐름: 실시간(deltaTime)을 더함
    }
}
