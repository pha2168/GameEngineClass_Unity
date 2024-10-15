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
        //{ // 마우스 좌클릭 인식
        //    Vector3 vecBullet = new Vector3(0, 0, 100); // 총알의 방향과 힘
        //    shootBullet(vecBullet);
        //}
    }
    // 총알 발사 함수
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

            Destroy(gameObject, 0.2f); // 충돌하고 0.2초 후에 오브젝트 삭제
            Destroy(coll.gameObject, 0.2f);
        }
    }
}
