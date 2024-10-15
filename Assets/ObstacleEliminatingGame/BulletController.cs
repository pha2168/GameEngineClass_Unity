using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 5.0f);
    }
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{ // ���콺 ��Ŭ�� �ν�
        //    Vector3 vecBullet = new Vector3(0, 0, 100); // �Ѿ��� ����� ��
        //    shootBullet(vecBullet);
        //}
    }
    // �Ѿ� �߻� �Լ�
    public void shootBullet(Vector3 vecBullet)
    {
        Rigidbody rigBody = GetComponent<Rigidbody>();
        rigBody.AddForce(vecBullet);
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "ENEMY")
        {
            GameObject scoreManagerObj = GameObject.Find("ScoreManager");
            ScoreManager scoreManagerScr = scoreManagerObj.GetComponent<ScoreManager>();
            scoreManagerScr.incScore();

            Destroy(gameObject, 0.2f); // �浹�ϰ� 0.2�� �Ŀ� ������Ʈ ����
            Destroy(coll.gameObject, 0.2f);
        }
    }
}
