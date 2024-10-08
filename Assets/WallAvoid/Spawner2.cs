using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject wallPrefab; // 생성할 프리펩 객체 지정
    public float interval = 1.5f;
    public float range = 3.0f; // 랜덤 값 범위

    void Start()
    {
        StartCoroutine(CreateWall()); // Coroutine을 사용하기 위한 등록 함수
        
    }
    IEnumerator CreateWall()
    { // Ienumerator를 사용하여 돌아올 위치를 기억
        WaitForSeconds wait = new WaitForSeconds(interval); // 기다릴 시간 등록
        while (true)
        {
            float wallPosY = Random.Range(-range, range);
            transform.position = new Vector3(transform.position.x, wallPosY, transform.position.z);
            Instantiate(wallPrefab, transform.position, transform.rotation);
            yield return wait; // 잠시 중단
        }
    }
}
