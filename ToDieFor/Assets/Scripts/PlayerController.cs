using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float mouseSensivity = 750f;
    float xRotation = 0f;

    public Transform playerBody;

    public float clampX = -20f;
    public float clampY = 20f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Lock cursor in place
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime * 1.7f;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, clampX, clampY);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnlocK();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            LocK();
        }
    }
    
    public Transform cameraTransform; // Reference to your camera or object to be rotated
    public float tiltAngle = 45f; // Tilt angle when moving
    public float resetSpeed = 5f; // Speed at which the camera resets its rotation

    private bool isMovingHorizontal = false;
    private bool isMovingVertical = false;
    private bool isResetting = false;

    void FixedUpdate()
    {
        // Get the horizontal and vertical input axes
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Check if the player is moving right or left
        if (verticalInput < 0)
        {
            // Player is moving right
            Debug.Log("Moving Right");
            RotateCamera(Vector3.left); // Tilt the camera to the right
            isMovingHorizontal = true;
            isResetting = false; // Cancel any ongoing reset
        }
        else if (verticalInput > 0)
        {
            // Player is moving left
            Debug.Log("Moving Left");
            RotateCamera(Vector3.right); // Tilt the camera to the left
            isMovingHorizontal = true;
            isResetting = false; // Cancel any ongoing reset
        }
        else
        {
            isMovingHorizontal = false;
        }

        // Check if the player is moving forward or backward
        if (horizontalInput > 0)
        {
            // Player is moving forward
            Debug.Log("Moving Forward");
            RotateCamera(Vector3.back); // Tilt the camera forward
            isMovingVertical = true;
            isResetting = false; // Cancel any ongoing reset
        }
        else if (horizontalInput < 0)
        {
            // Player is moving backward
            Debug.Log("Moving Backward");
            RotateCamera(Vector3.forward); // Tilt the camera backward
            isMovingVertical = true;
            isResetting = false; // Cancel any ongoing reset
        }
        else
        {
            isMovingVertical = false;
        }

        // Player is not moving horizontally or vertically
        if (!isMovingHorizontal && !isMovingVertical && !isResetting)
        {
            // Player released the key, start resetting the camera rotation
            isResetting = true;
        }

        // Continue resetting the camera rotation
        if (isResetting)
        {
            ResetCameraRotation();
        }
    }

    void RotateCamera(Vector3 rotationAxis)
    {
        // Apply the rotation to the camera or the designated object
        Quaternion targetRotation = Quaternion.Euler(rotationAxis * tiltAngle);
        cameraTransform.localRotation = Quaternion.Slerp(cameraTransform.localRotation, targetRotation, Time.deltaTime * 5f);
    }

    void ResetCameraRotation()
    {
        // Reset the camera rotation to default gradually
        Quaternion targetRotation = Quaternion.identity; // Quaternion.identity represents no rotation
        cameraTransform.localRotation = Quaternion.Slerp(cameraTransform.localRotation, targetRotation, Time.deltaTime * resetSpeed);
    }

    private void UnlocK()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void LocK()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}