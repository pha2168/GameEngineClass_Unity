using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoot : MonoBehaviour
{
    public GameObject prefab = null;

    private AudioSource audio;
    public AudioClip jumpSound; // jump ����
    public AudioClip BGMSound; // BGM ����

    public Texture2D icon = null;
    public static string text = "test";


    void Start()
    {
        // GameObject�� <AudioSource> component �߰�
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.loop = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Instantiate(prefab);

            // prefab�������� ������� GameObject�� ������
            GameObject prefabObj = GameObject.Instantiate(this.prefab) as GameObject;

            // ������ GameObject�� ������ ����
            float rnd = Random.Range(-2.0f, 2.0f);
            prefabObj.transform.position = new Vector3(rnd, 1.0f, 1.0f);

            this.audio.clip = this.jumpSound;
            this.audio.Play(); // audio clip�� ����ִ� ������ ���
        }
        if (Input.GetMouseButtonDown(1)) {
            this.audio.clip = this.BGMSound;
            if (this.audio.isPlaying == false) // replay ���� �ƴϸ�
            this.audio.Play(); // audio clip ������ ���
        }

    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width / 2, 64, 64, 64), icon);
        GUI.Label(new Rect(Screen.width / 2, 128, 128, 32), text);
    }
}
