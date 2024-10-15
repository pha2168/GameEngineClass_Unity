using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab 정보를 지정
    public int bulletPower = 200;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Prefab을 이용하여 오브젝트 생성
            GameObject bulletObj = Instantiate(bulletPrefab, // 지정한 prefab 생성
            transform.position, transform.rotation); // 생성할 위치와 방향
                                                     // BulletController script를 찾아 shootBullet() 호출(총알 발사)
            Vector3 vecBullet = new Vector3(0, 0, bulletPower);
            BulletController bulletControllerScr = bulletObj.GetComponent<BulletController>();
            bulletControllerScr.shootBullet(vecBullet);
        }
    }
}
