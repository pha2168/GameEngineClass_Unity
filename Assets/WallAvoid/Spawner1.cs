using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject wallPrefab; // 생성할 프리펩 객체 지정
    public float waitTime = 1.5f; // 기다리는 시간
    private float timer = 0f; // 현재까지 흘러간 시간

    public float range = 3.0f; // 랜덤 값 범위

    void Start()
    {
    }

    void Update()
    {
        if (timer <= waitTime)
        {
            timer += Time.deltaTime; // 유니티에서 실시간 측정 방법
        }
        else
        {
            float wallPosY = Random.Range(-range, range);
            transform.position = new Vector3(transform.position.x, wallPosY, transform.position.z);
            Instantiate(wallPrefab, transform.position, transform.rotation); // 지정한 객체 생성
            timer = 0f; // 현재까지 흘러간 시간 리셋
        }
    }
}
