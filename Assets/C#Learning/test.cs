using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int age;
        age = 30;
        Debug.Log(age);

        float height1 = 160.5f;
        float height2;

        height2 = height1;
        Debug.Log(height2);

        string name;
        name = "GDragon";
        Debug.Log(name);

        string str1 = "happy";
        string str2 = "birthday";
        string massage;

        massage = str1 + str2;
        Debug.Log(massage);

        for(int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }


        int[] tana = { 123, 234, 345, 456, 567 };

        for(int i = 0;i < tana.Length; i++)
        {
            Debug.Log(tana[i]);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
    }
}
