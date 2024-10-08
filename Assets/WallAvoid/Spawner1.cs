using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject wallPrefab; // ������ ������ ��ü ����
    public float waitTime = 1.5f; // ��ٸ��� �ð�
    private float timer = 0f; // ������� �귯�� �ð�

    public float range = 3.0f; // ���� �� ����

    void Start()
    {
    }

    void Update()
    {
        if (timer <= waitTime)
        {
            timer += Time.deltaTime; // ����Ƽ���� �ǽð� ���� ���
        }
        else
        {
            float wallPosY = Random.Range(-range, range);
            transform.position = new Vector3(transform.position.x, wallPosY, transform.position.z);
            Instantiate(wallPrefab, transform.position, transform.rotation); // ������ ��ü ����
            timer = 0f; // ������� �귯�� �ð� ����
        }
    }
}
