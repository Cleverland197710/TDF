using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{

    private void OnMouseUpAsButton()
    {
        Debug.Log("Plate Picked Up!");
        GetComponent<MeshRenderer>().enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
