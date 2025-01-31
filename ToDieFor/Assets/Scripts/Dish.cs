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
        GetComponent<BoxCollider>().enabled = false;
    }


    private void OnMouseUpAsButton()
    {
        //Debug.Log("Plate Picked Up!");
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        //Invoke("appear", 1.0f);
        picked = true;
        Invoke("Clear", 5.5f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Bell.inBell == true)
        {
            //Debug.Log("speak");
            speak = true;
        }

        if (speak == true && Input.GetKeyDown(KeyCode.Alpha1))
        {
            //appear();
            isCup = true;
            Debug.Log("CupSpawned");
            Invoke("appear", 1.0f);
            //Debug.Log("Should BE Cup!");
        }

        if (speak == true && Input.GetKeyDown(KeyCode.Alpha2))
        {
            //appear();
            isPan = true;
            Debug.Log("PancakeSpawned");
            Invoke("appear", 1.0f);
            //Debug.Log("Should BE Cup!");
        }

        if (speak == true && Input.GetKeyDown(KeyCode.Alpha3))
        {
            //appear();
            isEgg = true;
            Debug.Log("EggSpawned");
            Invoke("appear", 1.0f);
            //Debug.Log("Should BE Cup!");
        }
    }

    private void appear()
    {
        picked = false;
        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<BoxCollider>().enabled = true;
        //Debug.Log("appear");
    }

    private void Clear()
    {
        picked = false;
        isCup = false;
        isPan = false;
        isEgg = false;
        //speak = false;
    }
}
