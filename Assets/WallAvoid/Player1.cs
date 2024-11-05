using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{
    public float jumpPower;

    private new AudioSource audio; // 사운드 출력을 위해선 AudioSource 필요
    public AudioClip jumpSound; // 재생(replay)할 음원 파일

    // Start is called before the first frame update
    void Start()
    {
        this.audio = this.gameObject.AddComponent<AudioSource>(); // AudioSource 추가
        this.audio.clip = this.jumpSound;
        this.audio.loop = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
            this.audio.Play(); // 또는 this.audio.PlayOneShot(this.jumpSound) 사용
        }

    }

    void OnCollisionEnter(Collision col) // 두 collider 충돌시 자동 호출되고 Rigidbody가 필요함
    {
        SceneManager.LoadScene("Main");
    }
}
