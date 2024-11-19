using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DotPlayer : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ� ����
    public float rotationSpeed = 360f; // ȸ�� �ӵ� ����

    CharacterController characterController;
    Animator animator;

    void Start() {
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>(); // Animator ������Ʈ ������
    }


    void Update() {
        float xMove = Input.GetAxis("Horizontal"); // �¿� �Է¿� ���� -1~1�� ���� ����
        float zMove = Input.GetAxis("Vertical"); // ���� �Է¿� ���� -1~1�� ���� ����
        Vector3 moveDirection = new Vector3(xMove, 0, zMove);
        // Move()�� �̿��� �̵�, �浹 ó��, �ӵ� �� ��� ����
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);

        if(moveDirection.sqrMagnitude > 0.01f) {
           Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up); // Ÿ�� ������ ����
           transform.rotation = Quaternion.RotateTowards(
           transform.rotation, // ���� ����
           toRotation, // Ÿ�� ����
           rotationSpeed * Time.deltaTime); // ȸ�� �ӵ� 
        }

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
        // Speed �Ķ���͸� ���� ���� �ӵ��� ũ��(Character Controller)�� ����


        animator.SetFloat("Speed", characterController.velocity.magnitude);
        // Dot �±׸� ��������, Dot �±װ� ���� ���� ������Ʈ�� ã��
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


