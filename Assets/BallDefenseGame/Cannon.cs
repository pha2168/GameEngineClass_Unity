using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject prefab; // ���� ��Ƶα� ���� ����
    public float power; // ���� ������ ��
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            GameObject bullet = LoadBullet();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    //�� �߿��� Ray! ī�޶� ��ũ�� �� �� ���콺 Ŭ�� ��ġ
            Vector3 dir = ray.direction.normalized;
            bullet.GetComponent<Rigidbody>().velocity = dir * power;
        }
    }
    // Bullet�� �̿��Ͽ� ���� ����
    GameObject LoadBullet() {
        var bullet = GameObject.Instantiate(prefab) as GameObject;
        bullet.transform.parent = transform;
        bullet.transform.localPosition = Vector3.zero;
        return bullet;
    }
}
