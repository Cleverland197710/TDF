using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish : MonoBehaviour
{
    public static bool picked;

    private void Awake()
    {
        picked = true;
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("Plate Picked Up!");
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<SphereCollider>().enabled = false;
        Invoke("appear", 1.0f);
        picked = true;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void appear()
    {
        picked = false;
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<SphereCollider>().enabled = true;
    }
}
