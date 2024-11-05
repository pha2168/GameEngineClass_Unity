using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{
    public float jumpPower;

    private new AudioSource audio; // ���� ����� ���ؼ� AudioSource �ʿ�
    public AudioClip jumpSound; // ���(replay)�� ���� ����

    // Start is called before the first frame update
    void Start()
    {
        this.audio = this.gameObject.AddComponent<AudioSource>(); // AudioSource �߰�
        this.audio.clip = this.jumpSound;
        this.audio.loop = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
            this.audio.Play(); // �Ǵ� this.audio.PlayOneShot(this.jumpSound) ���
        }

    }

    void OnCollisionEnter(Collision col) // �� collider �浹�� �ڵ� ȣ��ǰ� Rigidbody�� �ʿ���
    {
        SceneManager.LoadScene("Main");
    }
}
