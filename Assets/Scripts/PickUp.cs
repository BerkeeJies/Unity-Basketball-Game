using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    [SerializeField] private float ballThrowingForce;
    [SerializeField] private Transform playerCamera;
    [SerializeField] private float ballDistance = 2f;
    private bool holding = false;
    public Transform destination;

    [SerializeField] private GameObject ball;

    void OnMouseDown() {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.parent = GameObject.Find("Destination").transform;
        holding = true;
    }

    void OnMouseUp() {
        holding = false;
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);
    }

    void Update() {
        if(holding) {
            this.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;
        }

        if(GetComponent<Transform>().position.y <= -2) {
            GetComponent<Transform>().position = new Vector3(0,0,0);
            

        }

    }

}
