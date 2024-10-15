using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("A space bar is pressed..!");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        { // ↑키로 forward(전)
            this.transform.Translate(Vector3.forward * 3.0f * Time.deltaTime);
            // this.transform.Translate(new Vector3(0.0f, 0.0f, 3.0f * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        { // ↓키로 back(후)
            this.transform.Translate(Vector3.back * 3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        { // ←키로 left(좌)
            this.transform.Translate(Vector3.left * 3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        { // →키로 right(우)
            this.transform.Translate(Vector3.right * 3.0f * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.R))
        { // R키로 우회전
            this.transform.Rotate(0.0f, 90.0f * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.L))
        { // L키로 좌회전
            this.transform.Rotate(0.0f, -90.0f * Time.deltaTime, 0.0f);
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            float ran = Random.Range(0.0f, 5.0f);
            this.transform.position = new Vector3(-ran, 1.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            float ran = Random.Range(0.0f, 5.0f);
            this.transform.position = new Vector3(0.0f, 1.0f, -ran);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            float ran = Random.Range(0.0f, 5.0f);
            this.transform.position = new Vector3(ran, 1.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            float ran = Random.Range(0.0f, 5.0f);
            this.transform.position = new Vector3(0.0f, 1.0f, ran);
        }

        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("A left mouse button is pressed...!");
        }
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log(Input.mousePosition);
        }

        if (Input.GetKey(KeyCode.G))
        {
            GameObject shildObj = GameObject.Find("Shield") as GameObject;
            shildObj.GetComponent<Weapon>().bigsize(); // Weapon.cs의 bigsize() method 호출
        }
        
    }
}
