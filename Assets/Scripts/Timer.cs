using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {


    [SerializeField] Text timeText;

    int countDownValue = 90;
    // Start is called before the first frame update
    void Start() {
        countDownTimer();
    }

    void countDownTimer() {
        if (countDownValue > 0) {
            timeText.text = countDownValue.ToString();
            countDownValue--;
            Invoke("countDownTimer", 1);
        }else {
            timeText.text = "GAME OVER";
            SceneManager.LoadScene("GameOver");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
