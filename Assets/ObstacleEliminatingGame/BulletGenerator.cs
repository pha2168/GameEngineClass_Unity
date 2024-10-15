using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab ������ ����
    public int bulletPower = 200;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Prefab�� �̿��Ͽ� ������Ʈ ����
            GameObject bulletObj = Instantiate(bulletPrefab, // ������ prefab ����
            transform.position, transform.rotation); // ������ ��ġ�� ����
                                                     // BulletController script�� ã�� shootBullet() ȣ��(�Ѿ� �߻�)
            Vector3 vecBullet = new Vector3(0, 0, bulletPower);
            BulletController bulletControllerScr = bulletObj.GetComponent<BulletController>();
            bulletControllerScr.shootBullet(vecBullet);
        }
    }
}
