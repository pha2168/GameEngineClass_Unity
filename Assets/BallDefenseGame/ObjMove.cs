using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{
    public float power = 6.5f; // 이동속도
    private GameObject target;
    // 이동 목표 지점으로 "DeathZone"을 지정
    void Start() {
        target = GameObject.FindGameObjectWithTag("DeathZone");
    }
    // 목표 지점으로 이동
    void FixedUpdate() {
        Vector3 direction = target.transform.position - transform.position;
        GetComponent<Rigidbody>().AddForce(direction.normalized * power);
        transform.LookAt(direction);
    }
}
