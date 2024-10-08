using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceControl : MonoBehaviour
{
    public float force = 300.0f;
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        { // ��Ű�� ���� ����
            this.transform.GetComponent<Rigidbody>().AddForce(
            Vector3.forward * force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        { // ��Ű�� ���� ����
            this.transform.GetComponent<Rigidbody>().AddForce(
            Vector3.back * force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        { // ��Ű�� ���� ����
            this.transform.GetComponent<Rigidbody>().AddForce(
            Vector3.left * force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        { //��Ű�� ������ ����
            this.transform.GetComponent<Rigidbody>().AddForce(
            Vector3.right * force * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Keypad1))
        { // ��Ű(���� Ű�е�)�� 0
            Physics.gravity = Vector3.zero; // �߷��� 0���� ����
        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        { // ��Ű�� 8
            Physics.gravity = Vector3.up; // �߷��� �� �������� ����
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        { // ��Ű�� 2.
            Physics.gravity = Vector3.down; // �߷��� �Ʒ� �������� ����
        }
    }
}
