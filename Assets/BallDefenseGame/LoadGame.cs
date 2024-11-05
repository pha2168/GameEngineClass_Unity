using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void Loadgame() {
        UIController.gameOver = false;
        SceneManager.LoadScene("DefenseGame");
        Score.score = 0;
    }

}
