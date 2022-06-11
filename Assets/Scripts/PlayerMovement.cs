using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField] private Transform playerCamera;
    [SerializeField] private CharacterController playerController;

    [SerializeField] private float mouseSensivity = 5f;
    [SerializeField] private float movementSpeed = 4f;
    [SerializeField] private float jumpForce = 12f;
    [SerializeField] private float gravity = -9.81f;

    //TODO: Throw ball
    public GameObject ball;
    public float ballDistance = 2f;
    public float ballThrowingForce = 5f;


    private Vector3 velocity;
    private Vector3 playerMovementInput;
    private Vector2 playerMouseInput;
    private float camXRotation;
    

    void Start() {
        ball.GetComponent<Rigidbody>().useGravity = false;
    }

    void Update() {
        playerMovementInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        playerMouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        Move();
        Look();
    }

    void Move() {
        
        Vector3 moveVector = transform.forward * playerMovementInput.z + transform.right * playerMovementInput.x;

        if(playerController.isGrounded) {
            velocity.y = -3f;
            if (Input.GetKeyDown(KeyCode.Space)) {
                velocity.y = jumpForce;
            }
        } else {
            velocity.y -= gravity * -2f * Time.deltaTime;
        }

        

        playerController.Move(moveVector * movementSpeed * Time.deltaTime);
        playerController.Move(velocity * Time.deltaTime);
    }

    void Look() {
        
        camXRotation -= playerMouseInput.y * mouseSensivity;

        transform.Rotate(0f, playerMouseInput.x, 0f);
        camXRotation = Mathf.Clamp(camXRotation, -90, 90);

        playerCamera.localRotation = Quaternion.Euler(camXRotation, 0f, 0f);
    }
}
