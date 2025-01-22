using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish : MonoBehaviour
{
    public static bool picked;
    public static bool isCup;
    public static bool isPan;
    public static bool isEgg;
    public bool speak;


    private void Awake()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<SphereCollider>().enabled = false;
    }


    private void OnMouseUpAsButton()
    {
        Debug.Log("Plate Picked Up!");
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<SphereCollider>().enabled = false;
        Invoke("appear", 1.0f);
        picked = true;
        Clear();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Bell.inBell)
        {
            Debug.Log("Speak");
            speak = true;
        }

        if (speak == true && Input.GetKeyDown(KeyCode.Alpha1))
        {
            appear();
            isCup = true;
            Invoke("appear", 1.0f);
            Debug.Log("Should BE Cup!");
        }

        if (Bell.spawnPan == true)
        {
            appear();
            isPan = true;
            //Invoke("appear", 1.0f);
            Debug.Log("Should BE Pan!");
        }

        if (Bell.spawnEgg == true)
        {
            appear();
            isEgg = true;
            //Invoke("appear", 1.0f);
            Debug.Log("Should BE Egg!");
        }
    }

    private void appear()
    {
        picked = false;
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<SphereCollider>().enabled = true;
        Debug.Log("appear");    }

    private void Clear()
    {
        isCup = false;
        isPan = false;
        isEgg = false;
    }
}
