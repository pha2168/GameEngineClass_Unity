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
        float depth = this.transform.localScale.z; // x, y 방향에 대해 크기를 2배
        this.transform.localScale = new Vector3(2.0f, 2.0f, depth);
    }
}
