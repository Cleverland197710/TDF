using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultScript : MonoBehaviour
{
    Rigidbody rb;
    BoxCollider Table;
    public bool colliding;
    public bool climbing;
    public static bool vault;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        BoxCollider Table = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        colliding = true;
        Invoke("Colliding", 0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        colliding = true;
        Invoke("Colliding", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Invoke("Climbing", 0f);
        }

        if (climbing == true && colliding == true)
        {
            vault = true;
            Debug.Log("Vaulting");
        }
    }

    void Climbing()
    {
        climbing = true;
        Invoke("Falseify", 1f);
    }

    void Colliding()
    {
        colliding = true;
    }

    void Falseify()
    {
        climbing = false;
        colliding = false;
    }
}
