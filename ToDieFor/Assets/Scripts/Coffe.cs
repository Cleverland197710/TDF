using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffe : MonoBehaviour
{
    [SerializeField] LayerMask coffe;
    [SerializeField] LayerMask coffeLayer;
    public bool serving = false;

    private void OnMouseUpAsButton()
    {
        if (serving = true)
        {

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("coffeLayer"))
        {
            serving = true;
        }
    }
}
