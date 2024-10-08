using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject wallPrefab; // ������ ������ ��ü ����
    public float interval = 1.5f;
    public float range = 3.0f; // ���� �� ����

    void Start()
    {
        StartCoroutine(CreateWall()); // Coroutine�� ����ϱ� ���� ��� �Լ�
        
    }
    IEnumerator CreateWall()
    { // Ienumerator�� ����Ͽ� ���ƿ� ��ġ�� ���
        WaitForSeconds wait = new WaitForSeconds(interval); // ��ٸ� �ð� ���
        while (true)
        {
            float wallPosY = Random.Range(-range, range);
            transform.position = new Vector3(transform.position.x, wallPosY, transform.position.z);
            Instantiate(wallPrefab, transform.position, transform.rotation);
            yield return wait; // ��� �ߴ�
        }
    }
}
