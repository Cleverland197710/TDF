using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed = 10f;
    public bool colliding = false;
    public bool FailOrDead = false;
  //public float mouseSensivity = 100f;
  //float xRotation = 0f;

    public Transform playerBody;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       //ursor.lockState = CursorLockMode.Locked; // Lock cursor in place

    }

    // Update is called once per frame
    void Update()
    {
        

        /*if (FailOrDead == true)
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Movement>().enabled = false;
            Invoke(nameof(ReloadLevel), 1.3f);
        }*/

        /*
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -10f, 10f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        */

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Move in the direction the player is facing
        Vector3 moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;
        rb.velocity = new Vector3(moveDirection.x * moveSpeed, rb.velocity.y, moveDirection.z * moveSpeed);

        /*
          
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnlocK();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            LocK();
        }

        */

        if (Input.GetKey(KeyCode.Space) && colliding)
        { 
            rb.AddForce(Vector3.up * 90, ForceMode.Impulse);
            boost();
            colliding = false;
        }

        if (colliding == false)
        {
            moveSpeed = 20;
        }
    }

    /*
private void UnlocK()
{
    Cursor.lockState = CursorLockMode.None;
}

private void LocK()
{
    Cursor.lockState = CursorLockMode.Locked;
}

*/

    //https://youtu.be/_QajrabyTJc?si=JaUfdeVdYZ8RaGg9&t=488

    private void boost()
    {
        moveSpeed = 30;
        Debug.Log("run");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Vault"))
        {
            colliding = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Vault"))
        {
            colliding = true;
        }
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


