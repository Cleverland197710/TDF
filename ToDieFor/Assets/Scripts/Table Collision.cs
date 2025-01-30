using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (VaultScript.vault == true)
        {
            GetComponent<BoxCollider>().enabled = false;
        }

        if (VaultScript.vault == false)
        {
            GetComponent<BoxCollider>().enabled = true;
        }
    }
}
