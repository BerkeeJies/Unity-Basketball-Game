using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void StartGame() {
        Cursor.visible = true;
        SceneManager.LoadScene("SampleScene");
        GameManager.score = 0;
    }

    private void Update() {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
