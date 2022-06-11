using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreArea : MonoBehaviour {

    public GameObject effectObject;
    public Text scoreValue;

    void Start() {
    }

    void Update() {
        scoreValue.text = GameManager.score.ToString();
        
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "basketball") {
            effectObject.GetComponent<ParticleSystem>().Play();
            GameManager.score += 1;
            effectObject.GetComponent<ParticleSystem>().Clear();
        }
            
    }
}
