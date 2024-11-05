using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject prefab; // 공을 담아두기 위한 변수
    public float power; // 공을 날리는 힘
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            GameObject bullet = LoadBullet();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    //얘 중요함 Ray! 카메라 스크린 값 중 마우스 클릭 위치
            Vector3 dir = ray.direction.normalized;
            bullet.GetComponent<Rigidbody>().velocity = dir * power;
        }
    }
    // Bullet을 이용하여 공을 생성
    GameObject LoadBullet() {
        var bullet = GameObject.Instantiate(prefab) as GameObject;
        bullet.transform.parent = transform;
        bullet.transform.localPosition = Vector3.zero;
        return bullet;
    }
}
