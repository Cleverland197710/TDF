using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MeshCollider col = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (VaultScript.vault == true)
        {
            GetComponent<MeshCollider>().enabled = false;
        }

        if (VaultScript.vault == false)
        {
            GetComponent<MeshCollider>().enabled = true;
        }
    }
}
