using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{
    public float power = 6.5f; // �̵��ӵ�
    private GameObject target;
    // �̵� ��ǥ �������� "DeathZone"�� ����
    void Start() {
        target = GameObject.FindGameObjectWithTag("DeathZone");
    }
    // ��ǥ �������� �̵�
    void FixedUpdate() {
        Vector3 direction = target.transform.position - transform.position;
        GetComponent<Rigidbody>().AddForce(direction.normalized * power);
        transform.LookAt(direction);
    }
}
