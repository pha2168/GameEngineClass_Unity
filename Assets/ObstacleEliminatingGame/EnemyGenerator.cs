using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab ������ ����
    private float timeCount = 0.0f; // ���� �ð�
    void Update()
    {
        float xPos = Random.Range(-5.0f, 5.0f);
        Vector3 randomPos = new Vector3(xPos, 1.0f, 4.0f);
        if (timeCount > 5.0f)
        {
            Instantiate(enemyPrefab, randomPos, transform.rotation); // ������ ��ġ�� ����
            timeCount = 0.0f;
        }
        timeCount += Time.deltaTime; // �ð��� �帧: �ǽð�(deltaTime)�� ����
    }
}
