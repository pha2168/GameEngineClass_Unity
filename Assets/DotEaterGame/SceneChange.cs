using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// SceneChanger.cs
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {


    public string nextSceneName;


    void Update() {

        if(Input.GetButtonDown("Submit")) {
            SceneManager.LoadScene(nextSceneName);
        }

    }


}
