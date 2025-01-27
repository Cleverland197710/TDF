using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour
{
    public static bool inBell;
    public static bool spawnCup;
    public static bool spawnPan;
    public static bool spawnEgg;

    private void Awake()
    {
        spawnCup = false;
        spawnPan = false;
        spawnEgg = false;
    }

    private void OnMouseUp()
    {
        inBell=true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inBell == true)
        {
            Debug.Log("Ding!");

            if (Input.GetKeyUp(KeyCode.Alpha1))
            {
                Cup();
                Debug.Log("InputRecived");
            }

            if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                Pan();
            }

            if (Input.GetKeyUp(KeyCode.Alpha3))
            {
                Egg();
            }
        }
    }


    void Cup()
    {
        Debug.Log("Cup");
        spawnCup = true;
        Invoke("Off", 5f);
    }

    void Pan()
    {
        spawnPan = true;
        inBell = false;
        Invoke("Off", 1.5f);
    }

    void Egg()
    {
        spawnEgg = true;
        inBell = false;
        Invoke("Off", 1.5f);
    }

    void Off()
    {
        inBell = false; 
        spawnCup = false;
        spawnPan = false;
        spawnEgg = false;
    }
}
