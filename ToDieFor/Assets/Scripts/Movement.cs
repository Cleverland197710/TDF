using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed = 10f;
    public float mouseSensivity = 100f;

    public Transform playerBody;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked; // Lock cursor in place

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Move in the direction the player is facing
        Vector3 moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;
        rb.velocity = new Vector3(moveDirection.x * moveSpeed, rb.velocity.y, moveDirection.z * moveSpeed);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnlocK();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            LocK();
        }
    }

    private void UnlocK()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void LocK()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    //https://youtu.be/_QajrabyTJc?si=JaUfdeVdYZ8RaGg9&t=488
}


