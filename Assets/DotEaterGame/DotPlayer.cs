using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DotPlayer : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도 지정
    public float rotationSpeed = 360f; // 회전 속도 지정

    CharacterController characterController;
    Animator animator;

    void Start() {
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>(); // Animator 컴포넌트 가져옴
    }


    void Update() {
        float xMove = Input.GetAxis("Horizontal"); // 좌우 입력에 대한 -1~1의 값을 얻음
        float zMove = Input.GetAxis("Vertical"); // 상하 입력에 대한 -1~1의 값을 얻음
        Vector3 moveDirection = new Vector3(xMove, 0, zMove);
        // Move()를 이용해 이동, 충돌 처리, 속도 값 얻기 가능
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);

        if(moveDirection.sqrMagnitude > 0.01f) {
           Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up); // 타겟 방향을 생성
           transform.rotation = Quaternion.RotateTowards(
           transform.rotation, // 현재 방향
           toRotation, // 타켓 방향
           rotationSpeed * Time.deltaTime); // 회전 속도 
        }

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
        // Speed 파라미터를 통해 현재 속도의 크기(Character Controller)를 전달


        animator.SetFloat("Speed", characterController.velocity.magnitude);
        // Dot 태그를 가져오고, Dot 태그가 붙은 게임 오브젝트를 찾음
        if(GameObject.FindGameObjectsWithTag("Dot").Length == 0) {
            SceneManager.LoadScene("Dot");
        }
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag == "Dot") {
            Destroy(other.gameObject);
        }
        if(other.tag == "Enemy") {
            SceneManager.LoadScene("Dot");
        }
    }
}


