using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bigsize()
    {
        float depth = this.transform.localScale.z; // x, y ���⿡ ���� ũ�⸦ 2��
        this.transform.localScale = new Vector3(2.0f, 2.0f, depth);
    }
}
